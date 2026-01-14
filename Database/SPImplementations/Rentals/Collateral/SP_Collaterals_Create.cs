namespace VRMS.Database.SPImplementations.Rentals.Collateral;

public static class SP_Collaterals_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_collaterals_create;

                                  CREATE PROCEDURE sp_collaterals_create (
                                      IN p_rental_id INT,
                                      IN p_type VARCHAR(50),
                                      IN p_description VARCHAR(255),
                                      IN p_reference_number VARCHAR(100),
                                      IN p_received_at DATETIME
                                  )
                                  BEGIN
                                      INSERT INTO collaterals (
                                          rental_id,
                                          type,
                                          description,
                                          reference_number,
                                          received_at,
                                          status
                                      )
                                      VALUES (
                                          p_rental_id,
                                          p_type,
                                          p_description,
                                          p_reference_number,
                                          p_received_at,
                                          'Held'
                                      );

                                      SELECT LAST_INSERT_ID() AS collateral_id;
                                  END;
                                  """;
}