namespace VRMS.Database.SPImplementations.Rentals.CollateralPhoto;

public static class SP_CollateralPhotos_Add
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collateral_photos_add;

                                  CREATE PROCEDURE sp_collateral_photos_add (
                                      IN p_collateral_id INT,
                                      IN p_file_path VARCHAR(255),
                                      IN p_photo_type VARCHAR(50)
                                  )
                                  BEGIN
                                      INSERT INTO collateral_photos (
                                          collateral_id,
                                          file_path,
                                          photo_type
                                      )
                                      VALUES (
                                          p_collateral_id,
                                          p_file_path,
                                          p_photo_type
                                      );
                                  END;
                                  """;
}