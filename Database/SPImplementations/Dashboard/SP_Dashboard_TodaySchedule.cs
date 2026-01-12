namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_TodaySchedule
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_today_schedule;

                                  CREATE PROCEDURE sp_dashboard_today_schedule()
                                  BEGIN
                                      -- =========================
                                      -- PICKUPS (RESERVATIONS)
                                      -- =========================
                                      SELECT
                                          'Pickup' AS type,
                                          CONCAT(v.make, ' ', v.model, ' (', v.license_plate, ')') AS vehicle,
                                          CONCAT(c.first_name, ' ', c.last_name) AS customer,
                                          r.status AS status
                                      FROM reservations r
                                      JOIN vehicles v ON v.id = r.vehicle_id
                                      JOIN customers c ON c.id = r.customer_id
                                      WHERE DATE(r.start_date) = CURDATE()
                                        AND r.status <> 'Cancelled'

                                      UNION ALL

                                      -- =========================
                                      -- RETURNS (RENTALS)
                                      -- =========================
                                      SELECT
                                          'Return' AS type,
                                          CONCAT(v.make, ' ', v.model, ' (', v.license_plate, ')') AS vehicle,
                                          CONCAT(c.first_name, ' ', c.last_name) AS customer,
                                          rt.status AS status
                                      FROM rentals rt
                                      JOIN reservations r ON r.id = rt.reservation_id
                                      JOIN vehicles v ON v.id = r.vehicle_id
                                      JOIN customers c ON c.id = r.customer_id
                                      WHERE DATE(rt.expected_return_date) = CURDATE()
                                        AND rt.status <> 'Completed'

                                      ORDER BY type DESC;
                                  END;
                                  """;
}
