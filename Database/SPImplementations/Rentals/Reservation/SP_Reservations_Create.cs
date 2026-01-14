namespace VRMS.Database.SPImplementations.Rentals.Reservation;

public static class SP_Reservations_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_create;

                                  CREATE PROCEDURE sp_reservations_create (
                                      IN p_customer_id INT,
                                      IN p_vehicle_id INT,
                                      IN p_start_date DATETIME,
                                      IN p_end_date DATETIME,
                                      IN p_estimated_rental DECIMAL(10,2),
                                      IN p_reservation_fee DECIMAL(10,2),
                                      IN p_reservation_fee_rate DECIMAL(5,2),
                                      IN p_status VARCHAR(50)
                                  )
                                  BEGIN
                                      INSERT INTO reservations (
                                          customer_id,
                                          vehicle_id,
                                          start_date,
                                          end_date,
                                          estimated_rental_amount,
                                          reservation_fee_amount,
                                          reservation_fee_rate,
                                          status
                                      )
                                      VALUES (
                                          p_customer_id,
                                          p_vehicle_id,
                                          p_start_date,
                                          p_end_date,
                                          p_estimated_rental,
                                          p_reservation_fee,
                                          p_reservation_fee_rate,
                                          p_status
                                      );

                                      SELECT LAST_INSERT_ID() AS reservation_id;
                                  END;
                                  """;
}