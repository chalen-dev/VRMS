namespace VRMS.DTOs.Reports;
public class KpiReportDto
{
    public int TotalVehicles { get; set; }
    public int TotalRentals { get; set; }
    public int TotalRentalDays { get; set; }
    public decimal TotalRevenue { get; set; }
    public decimal AverageRentalDurationDays { get; set; }
    public decimal FleetUtilizationPercent { get; set; }
    public int DamageIncidentCount { get; set; }
}