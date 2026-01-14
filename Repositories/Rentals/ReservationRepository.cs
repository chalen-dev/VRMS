using System.Data;
using VRMS.Database;
using VRMS.DTOs.Reservation;
using VRMS.Enums;
using VRMS.Models.Rentals;

namespace VRMS.Repositories.Rentals;

public class ReservationRepository
{
    // -------------------------------------------------
    // CREATE
    // -------------------------------------------------

    public int Create(
        int customerId,
        int vehicleId,
        DateTime start,
        DateTime end,
        decimal estimatedRental,
        decimal reservationFee,
        decimal reservationFeeRate,
        ReservationStatus status)
    {
        var table = DB.Query(
            "CALL sp_reservations_create(@cid,@vid,@start,@end,@est,@fee,@rate,@status);",
            ("@cid", customerId),
            ("@vid", vehicleId),
            ("@start", start),
            ("@end", end),
            ("@est", estimatedRental),
            ("@fee", reservationFee),
            ("@rate", reservationFeeRate),
            ("@status", status.ToString())
        );

        return Convert.ToInt32(
            table.Rows[0]["reservation_id"]);
    }


    // -------------------------------------------------
    // UPDATE
    // -------------------------------------------------

    public void UpdateStatus(
        int reservationId,
        ReservationStatus status)
    {
        DB.Execute(
            "CALL sp_reservations_update_status(@id,@status);",
            ("@id", reservationId),
            ("@status", status.ToString())
        );
    }

    public void Cancel(int reservationId)
    {
        DB.Execute(
            "CALL sp_reservations_cancel(@id);",
            ("@id", reservationId)
        );
    }

    // -------------------------------------------------
    // READ
    // -------------------------------------------------

    public Reservation GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_reservations_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "Reservation not found.");

        return Map(table.Rows[0]);
    }

    public List<Reservation> GetByCustomer(int customerId)
        => MapList(DB.Query(
            "CALL sp_reservations_get_by_customer(@cid);",
            ("@cid", customerId)
        ));

    public List<Reservation> GetByVehicle(int vehicleId)
        => MapList(DB.Query(
            "CALL sp_reservations_get_by_vehicle(@vid);",
            ("@vid", vehicleId)
        ));
    
    public bool IsReservationFeePaid(int reservationId)
    {
        var table = DB.Query(
            "CALL sp_reservations_is_fee_paid(@rid);",
            ("@rid", reservationId)
        );

        return Convert.ToInt32(
            table.Rows[0]["cnt"]) > 0;
    }

    // -------------------------------------------------
    // MAPPING
    // -------------------------------------------------

    private static Reservation Map(DataRow row)
    {
        return new Reservation
        {
            Id = Convert.ToInt32(row["id"]),
            CustomerId =
                Convert.ToInt32(row["customer_id"]),
            VehicleId =
                Convert.ToInt32(row["vehicle_id"]),
            StartDate =
                Convert.ToDateTime(row["start_date"]),
            EndDate =
                Convert.ToDateTime(row["end_date"]),
            EstimatedRentalAmount =
                Convert.ToDecimal(row["estimated_rental_amount"]),
            ReservationFeeAmount =
                Convert.ToDecimal(row["reservation_fee_amount"]),
            ReservationFeeRate =
                Convert.ToDecimal(row["reservation_fee_rate"]),
            Status =
                Enum.Parse<ReservationStatus>(
                    row["status"].ToString()!, true)
        };
    }

    private static List<Reservation> MapList(
        DataTable table)
    {
        var list = new List<Reservation>();
        foreach (DataRow row in table.Rows)
            list.Add(Map(row));
        return list;
    }
    
    // -------------------------------------------------
    // ADMIN LIST (GRID)
    // -------------------------------------------------
    public List<ReservationGridRow> GetAllForGrid()
    {
        var table = DB.Query("CALL sp_reservations_get_all();");

        var list = new List<ReservationGridRow>();
        foreach (DataRow row in table.Rows)
        {
            var r = new ReservationGridRow
            {
                ReservationId = Convert.ToInt32(row["id"]),
                CustomerId = Convert.ToInt32(row["customer_id"]),
                CustomerName = $"{row["customer_first_name"]} {row["customer_last_name"]}",
                VehicleId = Convert.ToInt32(row["vehicle_id"]),
                VehicleName = $"{row["vehicle_year"]} {row["vehicle_make"]} {row["vehicle_model"]}",
                StartDate = Convert.ToDateTime(row["start_date"]),
                EndDate = Convert.ToDateTime(row["end_date"]),
                Status = Enum.Parse<ReservationStatus>(row["status"].ToString()!, true)
            };

            list.Add(r);
        }

        return list;
    }

}
