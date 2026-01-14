using System;
using System.IO;
using VRMS.Enums;
using VRMS.Helpers.Storage;
using VRMS.Models.Rentals;
using VRMS.Repositories.Rentals;

namespace VRMS.Services.Rental;

public class CollateralService
{
    // -------------------------------------------------
    // STORAGE CONFIG
    // -------------------------------------------------

    private const string CollateralPhotoFolder = "Collaterals";
    private const string FrontPhotoFileName = "front";
    private const string BackPhotoFileName = "back";
    private const string OtherPhotoBaseName = "other";

    // -------------------------------------------------
    // DEPENDENCIES
    // -------------------------------------------------

    private readonly CollateralRepository _collateralRepo;
    private readonly CollateralPhotoRepository _photoRepo;

    // -------------------------------------------------
    // CONSTRUCTOR
    // -------------------------------------------------

    public CollateralService()
    {
        _collateralRepo = new CollateralRepository();
        _photoRepo = new CollateralPhotoRepository();
    }

    // -------------------------------------------------
    // COLLATERALS
    // -------------------------------------------------

    public int CreateCollateral(
        int rentalId,
        CollateralType type,
        string? description,
        string? referenceNumber)
    {
        return _collateralRepo.Create(
            rentalId,
            type,
            description,
            referenceNumber,
            DateTime.Now
        );
    }

    public void ReturnCollateral(int collateralId)
    {
        _collateralRepo.MarkReturned(
            collateralId,
            DateTime.Now
        );
    }

    public void MarkCollateralLost(int collateralId)
    {
        _collateralRepo.MarkLost(collateralId);
    }

    public Collateral GetCollateralById(int collateralId)
        => _collateralRepo.GetById(collateralId);

    public IReadOnlyList<Collateral> GetCollateralsByRental(int rentalId)
        => _collateralRepo.GetByRental(rentalId);

    // -------------------------------------------------
    // PHOTO MANAGEMENT (LIKE DRIVERS LICENSE)
    // -------------------------------------------------

    public void AddOrReplacePhoto(
        int rentalId,
        int collateralId,
        CollateralPhotoType photoType,
        Stream photoStream,
        string originalFileName)
    {
        var baseFileName = photoType switch
        {
            CollateralPhotoType.Front => FrontPhotoFileName,
            CollateralPhotoType.Back => BackPhotoFileName,
            _ => $"{OtherPhotoBaseName}_{Guid.NewGuid():N}"
        };

        var relativePath =
            FileStorageHelper.SaveSingleFile(
                photoStream,
                originalFileName,
                Path.Combine(
                    CollateralPhotoFolder,
                    rentalId.ToString(),
                    collateralId.ToString()
                ),
                baseFileName
            );

        _photoRepo.Add(
            collateralId,
            relativePath,
            photoType
        );
    }

    public IReadOnlyList<CollateralPhoto>
        GetPhotosByCollateral(int collateralId)
        => _photoRepo.GetByCollateral(collateralId);

    public void DeleteCollateralPhoto(
        int rentalId,
        int collateralId,
        int photoId,
        string storedPath)
    {
        FileStorageHelper.DeleteFile(storedPath);
        _photoRepo.Delete(photoId);
    }

    public void DeleteAllCollateralPhotos(
        int rentalId,
        int collateralId)
    {
        FileStorageHelper.DeleteDirectory(
            Path.Combine(
                CollateralPhotoFolder,
                rentalId.ToString(),
                collateralId.ToString()
            )
        );
    }
}
