namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_RentalStats
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_rental_stats;

                                  CREATE PROCEDURE sp_dashboard_rental_stats()
                                  BEGIN
                                      SELECT
                                          -- Active rentals TODAY (date overlap)
                                          SUM(
                                              pickup_date <= CURDATE()
                                              AND expected_return_date >= CURDATE()
                                          ) AS active_rentals,

                                          -- Overdue rentals (ended before today)
                                          SUM(
                                              expected_return_date < CURDATE()
                                          ) AS overdue_rentals
                                      FROM rentals;
                                  END;
                                  """;
}