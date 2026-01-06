namespace VRMS.Database.StoredProcedures.Rentals.Reservation;

public static class SP_Reservations_Cancel
{
    public static string Sql() => """
                                  CREATE PROCEDURE sp_reservations_cancel (
                                      IN p_reservation_id INT
                                  )
                                  BEGIN
                                      UPDATE reservations
                                      SET status = 'Cancelled'
                                      WHERE id = p_reservation_id;
                                  END;
                                  """;
}