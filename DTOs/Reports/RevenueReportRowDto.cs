namespace VRMS.DTOs.Reports;
public class RevenueReportRowDto
{
    public int InvoiceId { get; set; }
    public int RentalId { get; set; }
    public string VehicleCode { get; set; } = "";
    public DateTime InvoiceDate { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
}