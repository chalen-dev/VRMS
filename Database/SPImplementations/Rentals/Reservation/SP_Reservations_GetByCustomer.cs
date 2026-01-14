namespace VRMS.Database.SPImplementations.Rentals.Reservation;

public static class SP_Reservations_GetByCustomer
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_get_by_customer;

                                  CREATE PROCEDURE sp_reservations_get_by_customer (
                                      IN p_customer_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          customer_id,
                                          vehicle_id,
                                          start_date,
                                          end_date,
                                          estimated_rental_amount,
                                          reservation_fee_amount,
                                          reservation_fee_rate,
                                          status
                                      FROM reservations
                                      WHERE customer_id = p_customer_id
                                      ORDER BY start_date DESC;
                                  END;
                                  """;
}