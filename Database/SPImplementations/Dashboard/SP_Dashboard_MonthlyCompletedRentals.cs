namespace VRMS.Database.SPImplementations.Dashboard;

public static class SP_Dashboard_MonthlyCompletedRentals
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_dashboard_monthly_completed_rentals;
                                  
                                  CREATE PROCEDURE sp_dashboard_monthly_completed_rentals (
                                      IN p_start_year INT,
                                      IN p_start_month INT,
                                      IN p_end_year INT,
                                      IN p_end_month INT
                                  )
                                  BEGIN
                                      DECLARE v_year INT;
                                      DECLARE v_month INT;
                                  
                                      CREATE TEMPORARY TABLE IF NOT EXISTS tmp_months (
                                          year INT,
                                          month INT
                                      );
                                  
                                      DELETE FROM tmp_months;
                                  
                                      SET v_year = p_start_year;
                                      SET v_month = p_start_month;
                                  
                                      WHILE (v_year < p_end_year)
                                            OR (v_year = p_end_year AND v_month <= p_end_month)
                                      DO
                                          INSERT INTO tmp_months (year, month)
                                          VALUES (v_year, v_month);
                                  
                                          SET v_month = v_month + 1;
                                          IF v_month = 13 THEN
                                              SET v_month = 1;
                                              SET v_year = v_year + 1;
                                          END IF;
                                      END WHILE;
                                  
                                      SELECT
                                          m.year,
                                          m.month,
                                          IFNULL(COUNT(r.id), 0) AS completed_rentals
                                      FROM tmp_months m
                                      LEFT JOIN rentals r
                                          ON YEAR(r.actual_return_date) = m.year
                                         AND MONTH(r.actual_return_date) = m.month
                                         AND r.status = 'Completed'
                                      GROUP BY m.year, m.month
                                      ORDER BY m.year, m.month;
                                  
                                      DROP TEMPORARY TABLE tmp_months;
                                  END;
                                  
                                  """;
}