namespace VRMS.Database.SPImplementations.Rentals.CollateralPhoto;

public static class SP_CollateralPhotos_Delete
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collateral_photos_delete;

                                  CREATE PROCEDURE sp_collateral_photos_delete (
                                      IN p_photo_id INT
                                  )
                                  BEGIN
                                      DELETE FROM collateral_photos
                                      WHERE id = p_photo_id;
                                  END;
                                  """;
}