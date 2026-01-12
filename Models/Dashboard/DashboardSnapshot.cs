namespace VRMS.Models.Dashboard;

public class DashboardSnapshot
{
    public DashboardFleetStats Fleet { get; init; } = null!;
    public DashboardRentalStats Rentals { get; init; } = null!;
    public DashboardRevenueStats Revenue { get; init; } = null!;

    public IReadOnlyList<DashboardMonthlyTrend> MonthlyTrends { get; init; }
        = Array.Empty<DashboardMonthlyTrend>();
}