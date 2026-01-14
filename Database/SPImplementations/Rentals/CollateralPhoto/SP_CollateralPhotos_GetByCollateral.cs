namespace VRMS.Database.SPImplementations.Rentals.CollateralPhoto;

public static class SP_CollateralPhotos_GetByCollateral
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collateral_photos_get_by_collateral;

                                  CREATE PROCEDURE sp_collateral_photos_get_by_collateral (
                                      IN p_collateral_id INT
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM collateral_photos
                                      WHERE collateral_id = p_collateral_id
                                      ORDER BY uploaded_at;
                                  END;
                                  """;
}