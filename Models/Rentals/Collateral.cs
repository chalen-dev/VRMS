using VRMS.Enums;

namespace VRMS.Models.Rentals;

public class Collateral
{
    public int Id { get; set; }

    // FK
    public int RentalId { get; set; }

    // Enum-backed MySQL ENUM
    public CollateralType Type { get; set; }

    // Optional metadata
    public string? Description { get; set; }
    public string? ReferenceNumber { get; set; }

    // Lifecycle
    public DateTime ReceivedAt { get; set; }
    public DateTime? ReturnedAt { get; set; }

    public CollateralStatus Status { get; set; }
}