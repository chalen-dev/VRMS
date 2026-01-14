namespace VRMS.Database.SPImplementations.Rentals.Collateral;

public static class SP_Collaterals_MarkLost
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collaterals_mark_lost;

                                  CREATE PROCEDURE sp_collaterals_mark_lost (
                                      IN p_collateral_id INT
                                  )
                                  BEGIN
                                      UPDATE collaterals
                                      SET status = 'Lost'
                                      WHERE id = p_collateral_id;
                                  END;
                                  """;
}