namespace VRMS.Database.SPImplementations.Rentals.Reservation;

public static class SP_Reservations_GetAll
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_get_all;

                                  CREATE PROCEDURE sp_reservations_get_all ()
                                  BEGIN
                                      SELECT
                                          r.id AS id,
                                          r.customer_id AS customer_id,
                                          c.first_name AS customer_first_name,
                                          c.last_name AS customer_last_name,
                                          r.vehicle_id AS vehicle_id,
                                          v.make AS vehicle_make,
                                          v.model AS vehicle_model,
                                          v.year AS vehicle_year,
                                          r.start_date AS start_date,
                                          r.end_date AS end_date,
                                          r.estimated_rental_amount,
                                          r.reservation_fee_amount,
                                          r.reservation_fee_rate,
                                          r.status AS status
                                      FROM reservations r
                                      JOIN customers c ON r.customer_id = c.id
                                      JOIN vehicles v  ON r.vehicle_id  = v.id
                                      ORDER BY r.start_date DESC;
                                  END;
                                  """;
}