using System.Data;
using VRMS.Models.Dashboard;
using VRMS.Repositories.Dashboard;

namespace VRMS.Services.Dashboard;

public class DashboardService
{
    private readonly DashboardRepository _repo;

    public DashboardService(DashboardRepository repo)
    {
        _repo = repo;
    }

    // =====================================================
    // MAIN ENTRY POINT
    // =====================================================

    /// <summary>
    /// Retrieves a complete dashboard snapshot.
    /// This is the ONLY method the UI should call.
    /// </summary>
    public DashboardSnapshot GetSnapshot(
        int year,
        int month)
    {
        // -----------------------------
        // DATE CONTEXT (FROM UI)
        // -----------------------------

        int selectedYear = year;
        int selectedMonth = month;

        // Chart: last 10 months including selected month
        var (startYear, startMonth) =
            GetMonthOffset(
                selectedYear,
                selectedMonth,
                -9);

        // -----------------------------
        // DATA FETCH
        // -----------------------------

        var fleetStats =
            _repo.GetFleetStats();

        var rentalStats =
            _repo.GetRentalStats();

        var revenueStats =
            _repo.GetMonthlyRevenue(
                selectedYear,
                selectedMonth);

        var monthlyTrends =
            _repo.GetMonthlyCompletedRentals(
                startYear,
                startMonth,
                selectedYear,
                selectedMonth);

        // -----------------------------
        // SNAPSHOT ASSEMBLY
        // -----------------------------

        return new DashboardSnapshot
        {
            Fleet = fleetStats,
            Rentals = rentalStats,
            Revenue = revenueStats,
            MonthlyTrends = monthlyTrends
        };
    }


    // =====================================================
    // INTERNAL HELPERS
    // =====================================================

    /// <summary>
    /// Offsets a year/month pair by N months.
    /// Example: (2025, 1) + (-1) → (2024, 12)
    /// </summary>
    private static (int year, int month)
        GetMonthOffset(
            int year,
            int month,
            int offset)
    {
        int totalMonths =
            (year * 12 + (month - 1)) + offset;

        int newYear =
            totalMonths / 12;

        int newMonth =
            (totalMonths % 12) + 1;

        return (newYear, newMonth);
    }
    // =====================================================
    // TODAY'S SCHEDULE
    // =====================================================

    public DataTable GetTodaySchedule()
    {
        return _repo.GetTodaySchedule();
    }

    // =====================================================
    // ALERTS
    // =====================================================

    public DataTable GetAlerts()
    {
        return _repo.GetAlerts();
    }
}
