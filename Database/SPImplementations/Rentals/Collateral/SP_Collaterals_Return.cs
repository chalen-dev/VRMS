namespace VRMS.Database.SPImplementations.Rentals.Collateral;

public static class SP_Collaterals_Return
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collaterals_return;

                                  CREATE PROCEDURE sp_collaterals_return (
                                      IN p_collateral_id INT,
                                      IN p_returned_at DATETIME
                                  )
                                  BEGIN
                                      UPDATE collaterals
                                      SET
                                          returned_at = p_returned_at,
                                          status = 'Returned'
                                      WHERE id = p_collateral_id;
                                  END;
                                  """;
}