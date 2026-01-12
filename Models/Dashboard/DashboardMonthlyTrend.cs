namespace VRMS.Models.Dashboard;

public class DashboardMonthlyTrend
{
    public int Year { get; init; }
    public int Month { get; init; }   // 1–12
    public int CompletedRentals { get; init; }
}