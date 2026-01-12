namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_MonthlyRevenue
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_monthly_revenue;

                                  CREATE PROCEDURE sp_dashboard_monthly_revenue (
                                      IN p_year INT,
                                      IN p_month INT
                                  )
                                  BEGIN
                                      SELECT
                                          IFNULL(SUM(total_amount), 0) AS monthly_revenue
                                      FROM invoices
                                      WHERE status = 'Paid'
                                        AND YEAR(generated_date) = p_year
                                        AND MONTH(generated_date) = p_month;
                                  END;
                                  """;
}