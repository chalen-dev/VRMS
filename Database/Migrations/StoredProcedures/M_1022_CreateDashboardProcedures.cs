using VRMS.Database.SPImplementations.Dashboard;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1022_CreateDashboardProcedures
{
    public static string Create() => $"""
                                      {SP_Dashboard_FleetStats.Sql()}
                                      {SP_Dashboard_RentalStats.Sql()}
                                      {SP_Dashboard_MonthlyRevenue.Sql()}
                                      {SP_Dashboard_MonthlyCompletedRentals.Sql()}
                                      {SP_Dashboard_TodaySchedule.Sql()}
                                      {SP_Dashboard_Alerts.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_dashboard_fleet_stats;
                                   DROP PROCEDURE IF EXISTS sp_dashboard_rental_stats;
                                   DROP PROCEDURE IF EXISTS sp_dashboard_monthly_revenue;
                                   DROP PROCEDURE IF EXISTS sp_dashboard_monthly_completed_rentals;
                                   DROP PROCEDURE IF EXISTS sp_dashboard_today_schedule;
                                   DROP PROCEDURE IF EXISTS sp_dashboard_alerts;
                                   """;
}