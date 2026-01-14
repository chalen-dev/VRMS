using VRMS.Enums;

namespace VRMS.Models.Rentals;

public class CollateralPhoto
{
    public int Id { get; set; }

    // FK
    public int CollateralId { get; set; }

    public string FilePath { get; set; } = null!;

    // Enum-backed MySQL ENUM
    public CollateralPhotoType PhotoType { get; set; }

    public DateTime UploadedAt { get; set; }
}