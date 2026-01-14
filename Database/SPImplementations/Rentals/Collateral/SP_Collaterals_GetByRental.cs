namespace VRMS.Database.SPImplementations.Rentals.Collateral;

public static class SP_Collaterals_GetByRental
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collaterals_get_by_rental;

                                  CREATE PROCEDURE sp_collaterals_get_by_rental (
                                      IN p_rental_id INT
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM collaterals
                                      WHERE rental_id = p_rental_id
                                      ORDER BY received_at;
                                  END;
                                  """;
}