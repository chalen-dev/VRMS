namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_create;
                                  
                                  CREATE PROCEDURE sp_users_create (
                                      IN p_username VARCHAR(50),
                                      IN p_password_hash VARCHAR(255),
                                      IN p_role VARCHAR(50),
                                      IN p_is_active BOOLEAN,
                                      IN p_photo_path VARCHAR(255)
                                  )
                                  BEGIN
                                      INSERT INTO users (
                                          username,
                                          password_hash,
                                          role,
                                          is_active,
                                          photo_path
                                      )
                                      VALUES (
                                          p_username,
                                          p_password_hash,
                                          p_role,
                                          p_is_active,
                                          p_photo_path
                                      );
                                  
                                      SELECT LAST_INSERT_ID() AS id;
                                  END;
                                  
                                  """;
}