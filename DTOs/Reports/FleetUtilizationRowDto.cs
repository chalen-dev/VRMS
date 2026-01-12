namespace VRMS.DTOs.Reports;
public class FleetUtilizationRowDto
{
    public int VehicleId { get; set; }
    public string VehicleCode { get; set; } = "";
    public string MakeModel { get; set; } = "";
    public int DaysRented { get; set; }
    public int TotalDays { get; set; }
    public decimal UtilizationPercent { get; set; } // 0..100
}