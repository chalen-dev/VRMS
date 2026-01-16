namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_FleetStats
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_fleet_stats;

                                  CREATE PROCEDURE sp_dashboard_fleet_stats()
                                  BEGIN
                                      SELECT
                                          -- Total fleet (excluding retired)
                                          COUNT(v.id) AS total_vehicles,

                                          -- Available TODAY:
                                          -- 1. Not retired
                                          -- 2. NOT rented today
                                          -- 3. NOT under maintenance today
                                          SUM(
                                              v.status = 'Available'
                                              AND v.id NOT IN (
                                                  -- Rentals overlapping today
                                                  SELECT r.vehicle_id
                                                  FROM rentals r
                                                  WHERE
                                                      r.pickup_date <= CURDATE()
                                                      AND r.expected_return_date >= CURDATE()
                                              )
                                              AND v.id NOT IN (
                                                  -- Maintenance overlapping today
                                                  SELECT m.vehicle_id
                                                  FROM maintenance_records m
                                                  WHERE
                                                      m.start_date <= CURDATE()
                                                      AND (m.end_date IS NULL OR m.end_date >= CURDATE())
                                                      AND m.status IN (0, 1) -- Scheduled, InProgress
                                              )
                                          ) AS available_vehicles,

                                          -- Under Maintenance TODAY (date overlap based)
                                          SUM(
                                              v.id IN (
                                                  SELECT m.vehicle_id
                                                  FROM maintenance_records m
                                                  WHERE
                                                      m.start_date <= CURDATE()
                                                      AND (m.end_date IS NULL OR m.end_date >= CURDATE())
                                                      AND m.status IN (0, 1) -- Scheduled, InProgress
                                              )
                                          ) AS under_maintenance_vehicles

                                      FROM vehicles v
                                      WHERE v.status != 'Retired';
                                  END;
                                  """;
}