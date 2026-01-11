namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_UpdatePhoto
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_update_photo;

                                  CREATE PROCEDURE sp_users_update_photo (
                                      IN p_user_id INT,
                                      IN p_photo_path VARCHAR(255)
                                  )
                                  BEGIN
                                      UPDATE users
                                      SET photo_path = p_photo_path
                                      WHERE id = p_user_id
                                        AND is_active = TRUE;
                                  END;
                                  """;
}