using System.Data;
using VRMS.Database;
using VRMS.Models.Dashboard;

namespace VRMS.Repositories.Dashboard;

public class DashboardRepository
{
    // =====================================================
    // FLEET STATS
    // =====================================================

    public DashboardFleetStats GetFleetStats()
    {
        var table = DB.Query(
            "CALL sp_dashboard_fleet_stats();"
        );

        // Stored procedure ALWAYS returns exactly 1 row
        var row = table.Rows[0];

        return new DashboardFleetStats
        {
            TotalVehicles =
                Convert.ToInt32(row["total_vehicles"]),

            AvailableVehicles =
                Convert.ToInt32(row["available_vehicles"]),

            UnderMaintenanceVehicles =
                Convert.ToInt32(row["under_maintenance_vehicles"])
        };
    }

    // =====================================================
    // RENTAL STATS
    // =====================================================

    public DashboardRentalStats GetRentalStats()
    {
        var table = DB.Query(
            "CALL sp_dashboard_rental_stats();"
        );

        var row = table.Rows[0];

        return new DashboardRentalStats
        {
            ActiveRentals =
                Convert.ToInt32(row["active_rentals"]),

            OverdueRentals =
                Convert.ToInt32(row["overdue_rentals"])
        };
    }

    // =====================================================
    // MONTHLY REVENUE
    // =====================================================

    public DashboardRevenueStats GetMonthlyRevenue(
        int year,
        int month)
    {
        var table = DB.Query(
            "CALL sp_dashboard_monthly_revenue(@year,@month);",
            ("@year", year),
            ("@month", month)
        );

        var row = table.Rows[0];

        return new DashboardRevenueStats
        {
            MonthlyRevenue =
                Convert.ToDecimal(row["monthly_revenue"])
        };
    }

    // =====================================================
    // MONTHLY COMPLETED RENTALS (CHART)
    // =====================================================

    public IReadOnlyList<DashboardMonthlyTrend>
        GetMonthlyCompletedRentals(
            int startYear,
            int startMonth,
            int endYear,
            int endMonth)
    {
        var table = DB.Query(
            "CALL sp_dashboard_monthly_completed_rentals(@sy,@sm,@ey,@em);",
            ("@sy", startYear),
            ("@sm", startMonth),
            ("@ey", endYear),
            ("@em", endMonth)
        );

        var list = new List<DashboardMonthlyTrend>();

        foreach (DataRow row in table.Rows)
        {
            list.Add(new DashboardMonthlyTrend
            {
                Year =
                    Convert.ToInt32(row["year"]),

                Month =
                    Convert.ToInt32(row["month"]),

                CompletedRentals =
                    Convert.ToInt32(row["completed_rentals"])
            });
        }

        return list;
    }
    
    // =====================================================
    // TODAY'S SCHEDULE
    // =====================================================

    public DataTable GetTodaySchedule()
    {
        return DB.Query(    
            "CALL sp_dashboard_today_schedule();"
        );
    }
    
    // =====================================================
    // ALERTS
    // =====================================================

    public DataTable GetAlerts()
    {
        return DB.Query(
            "CALL sp_dashboard_alerts();"
        );
    }
}
