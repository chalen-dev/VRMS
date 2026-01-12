namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_FleetStats
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_fleet_stats;

                                  CREATE PROCEDURE sp_dashboard_fleet_stats()
                                  BEGIN
                                      SELECT
                                          COUNT(*) AS total_vehicles,
                                          IFNULL(SUM(status = 'Available'), 0) AS available_vehicles,
                                          IFNULL(SUM(status = 'UnderMaintenance'), 0) AS under_maintenance_vehicles
                                      FROM vehicles
                                      WHERE status != 'Retired';
                                  END;
                                  """;
}