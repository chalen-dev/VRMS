namespace VRMS.Database.StoredProcedures.Rentals.Reservation;

public static class SP_Reservations_GetById
{
    public static string Sql() => """
                                  CREATE PROCEDURE sp_reservations_get_by_id (
                                      IN p_reservation_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          customer_id,
                                          vehicle_id,
                                          start_date,
                                          end_date,
                                          status
                                      FROM reservations
                                      WHERE id = p_reservation_id;
                                  END;
                                  """;
}