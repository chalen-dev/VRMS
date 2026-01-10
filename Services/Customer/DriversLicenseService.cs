using System.Data;
using VRMS.Database;
using VRMS.Models.Customers;

namespace VRMS.Services.Customer;

public class DriversLicenseService
{
    private const string StorageRoot = "Storage";

    private const string DefaultDriversLicensePhotoPath = "Assets/img_placeholder.png";
    private const string DriversLicensePhotoFolder = "DriversLicenses";
    private const string FrontPhotoFileName = "front";
    private const string BackPhotoFileName  = "back";


    // ----------------------------
    // DRIVERS LICENSES
    // ----------------------------

    public int CreateDriversLicense(
        string licenseNumber,
        DateTime issueDate,
        DateTime expiryDate,
        string issuingCountry
    )
    {
        if (expiryDate <= issueDate)
            throw new InvalidOperationException(
                "Expiry date must be after issue date.");

        var table = DB.Query(
            "CALL sp_drivers_licenses_create(@number, @issue, @expiry, @country, @front, @back);",
            ("@number", licenseNumber),
            ("@issue", issueDate),
            ("@expiry", expiryDate),
            ("@country", issuingCountry),
            ("@front", DefaultDriversLicensePhotoPath),
            ("@back", DefaultDriversLicensePhotoPath)
        );

        return Convert.ToInt32(table.Rows[0]["drivers_license_id"]);
    }


    public DriversLicense GetDriversLicenseById(int licenseId)
    {
        var table = DB.Query(
            "CALL sp_drivers_licenses_get_by_id(@id);",
            ("@id", licenseId)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Drivers license not found.");

        return MapDriversLicense(table.Rows[0]);
    }

    public DriversLicense? GetDriversLicenseByNumber(string licenseNumber)
    {
        var table = DB.Query(
            "CALL sp_drivers_licenses_get_by_number(@number);",
            ("@number", licenseNumber)
        );

        if (table.Rows.Count == 0)
            return null;

        return MapDriversLicense(table.Rows[0]);
    }

    public void UpdateDriversLicense(
        int licenseId,
        DateTime issueDate,
        DateTime expiryDate,
        string issuingCountry
    )
    {
        if (expiryDate <= issueDate)
            throw new InvalidOperationException(
                "Expiry date must be after issue date.");

        DB.Execute(
            "CALL sp_drivers_licenses_update(@id, @issue, @expiry, @country);",
            ("@id", licenseId),
            ("@issue", issueDate),
            ("@expiry", expiryDate),
            ("@country", issuingCountry)
        );
    }


    // ----------------------------
    // UPSERT-LIKE HELPER
    // ----------------------------

    public int SaveDriversLicense(
        int? licenseId,
        string licenseNumber,
        DateTime issueDate,
        DateTime expiryDate,
        string issuingCountry,
        Stream? frontPhotoStream,
        string? frontFileName,
        Stream? backPhotoStream,
        string? backFileName
    )
    {
        int resolvedLicenseId;

        if (licenseId == null)
        {
            resolvedLicenseId = CreateDriversLicense(
                licenseNumber,
                issueDate,
                expiryDate,
                issuingCountry
            );
        }
        else
        {
            UpdateDriversLicense(
                licenseId.Value,
                issueDate,
                expiryDate,
                issuingCountry
            );

            resolvedLicenseId = licenseId.Value;
        }

        if (frontPhotoStream != null && !string.IsNullOrWhiteSpace(frontFileName))
        {
            SetFrontPhoto(resolvedLicenseId, frontPhotoStream, frontFileName);
        }

        if (backPhotoStream != null && !string.IsNullOrWhiteSpace(backFileName))
        {
            SetBackPhoto(resolvedLicenseId, backPhotoStream, backFileName);
        }

        return resolvedLicenseId;
    }


    public void DeleteDriversLicense(int licenseId)
    {
        // DB has RESTRICT on customers referencing licenses
        DB.Execute(
            "CALL sp_drivers_licenses_delete(@id);",
            ("@id", licenseId)
        );
    }

    // ----------------------------
    // PHOTO MANAGEMENT
    // ----------------------------

    private void SetDriversLicensePhoto(
        int licenseId,
        Stream photoStream,
        string originalFileName,
        string fileName,
        string procedure
    )
    {
        var extension = Path.GetExtension(originalFileName);
        if (string.IsNullOrWhiteSpace(extension))
            throw new InvalidOperationException("Invalid license photo file.");

        var directory = GetDriversLicensePhotoDirectory(licenseId);
        Directory.CreateDirectory(directory);

        var relativePath = Path.Combine(
            DriversLicensePhotoFolder,
            licenseId.ToString(),
            $"{fileName}{extension}"
        );

        var fullPath = Path.Combine(StorageRoot, relativePath);

        using var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
        photoStream.CopyTo(fs);

        DB.Execute(
            $"CALL {procedure}(@id, @path);",
            ("@id", licenseId),
            ("@path", relativePath)
        );
    }

    public void DeleteDriversLicensePhotos(int licenseId)
    {
        var directory = GetDriversLicensePhotoDirectory(licenseId);

        if (Directory.Exists(directory))
            Directory.Delete(directory, true);

        DB.Execute(
            "CALL sp_drivers_licenses_reset_photos(@id);",
            ("@id", licenseId)
        );
    }

    // ----------------------------
    // HELPERS
    // ----------------------------

    private static string GetDriversLicensePhotoDirectory(int licenseId)
    {
        return Path.Combine(
            StorageRoot,
            DriversLicensePhotoFolder,
            licenseId.ToString()
        );
    }

    private static DriversLicense MapDriversLicense(DataRow row)
    {
        string Resolve(object value) =>
            value == DBNull.Value || string.IsNullOrWhiteSpace(value.ToString())
                ? DefaultDriversLicensePhotoPath
                : value.ToString()!;

        return new DriversLicense
        {
            Id = Convert.ToInt32(row["id"]),
            LicenseNumber = row["license_number"].ToString()!,
            IssueDate = Convert.ToDateTime(row["issue_date"]),
            ExpiryDate = Convert.ToDateTime(row["expiry_date"]),
            IssuingCountry = row["issuing_country"].ToString()!,
            FrontPhotoPath = Resolve(row["front_photo_path"]),
            BackPhotoPath  = Resolve(row["back_photo_path"])
        };
    }

    
    public void SetFrontPhoto(
        int licenseId,
        Stream photoStream,
        string originalFileName
    )
    {
        SetDriversLicensePhoto(
            licenseId,
            photoStream,
            originalFileName,
            FrontPhotoFileName,
            "sp_drivers_licenses_set_front_photo"
        );
    }

    public void SetBackPhoto(
        int licenseId,
        Stream photoStream,
        string originalFileName
    )
    {
        SetDriversLicensePhoto(
            licenseId,
            photoStream,
            originalFileName,
            BackPhotoFileName,
            "sp_drivers_licenses_set_back_photo"
        );
    }
}
