namespace VRMS.Database.SPImplementations.Rentals.Collateral;

public static class SP_Collaterals_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collaterals_get_by_id;

                                  CREATE PROCEDURE sp_collaterals_get_by_id (
                                      IN p_collateral_id INT
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM collaterals
                                      WHERE id = p_collateral_id;
                                  END;
                                  """;
}