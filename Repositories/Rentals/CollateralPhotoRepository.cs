using System.Data;
using VRMS.Database;
using VRMS.Enums;
using VRMS.Models.Rentals;

namespace VRMS.Repositories.Rentals;

public class CollateralPhotoRepository
{
    // -------------------------------------------------
    // CREATE
    // -------------------------------------------------

    public void Add(
        int collateralId,
        string filePath,
        CollateralPhotoType photoType)
    {
        DB.Execute(
            "CALL sp_collateral_photos_add(@cid,@path,@type);",
            ("@cid", collateralId),
            ("@path", filePath),
            ("@type", photoType.ToString())
        );
    }

    // -------------------------------------------------
    // DELETE
    // -------------------------------------------------

    public void Delete(int photoId)
    {
        DB.Execute(
            "CALL sp_collateral_photos_delete(@id);",
            ("@id", photoId)
        );
    }

    // -------------------------------------------------
    // READ
    // -------------------------------------------------

    public List<CollateralPhoto> GetByCollateral(
        int collateralId)
    {
        var result = new List<CollateralPhoto>();

        var table = DB.Query(
            "CALL sp_collateral_photos_get_by_collateral(@cid);",
            ("@cid", collateralId)
        );

        foreach (DataRow row in table.Rows)
        {
            result.Add(Map(row));
        }

        return result;
    }

    // -------------------------------------------------
    // MAPPING
    // -------------------------------------------------

    private static CollateralPhoto Map(DataRow row)
    {
        return new CollateralPhoto
        {
            Id = Convert.ToInt32(row["id"]),
            CollateralId =
                Convert.ToInt32(row["collateral_id"]),
            FilePath = row["file_path"].ToString()!,
            PhotoType = Enum.Parse<CollateralPhotoType>(
                row["photo_type"].ToString()!, true),
            UploadedAt =
                Convert.ToDateTime(row["uploaded_at"])
        };
    }
}
