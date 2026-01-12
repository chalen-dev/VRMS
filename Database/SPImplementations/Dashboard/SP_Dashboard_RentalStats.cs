namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_RentalStats
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_rental_stats;

                                  CREATE PROCEDURE sp_dashboard_rental_stats()
                                  BEGIN
                                      SELECT
                                          IFNULL(SUM(status = 'Active'), 0) AS active_rentals,
                                          IFNULL(SUM(status = 'Late'), 0) AS overdue_rentals
                                      FROM rentals;
                                  END;
                                  """;
}