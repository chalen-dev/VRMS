namespace VRMS.Database.SPImplementations.Rentals.Reservation;

public static class SP_Reservations_IsFeePaid
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_is_fee_paid;

                                  CREATE PROCEDURE sp_reservations_is_fee_paid (
                                      IN p_reservation_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          COUNT(*) AS cnt
                                      FROM payments
                                      WHERE reservation_id = p_reservation_id
                                        AND payment_type = 'Reservation';
                                  END;
                                  """;
}