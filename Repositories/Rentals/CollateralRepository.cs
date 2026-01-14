using System.Data;
using VRMS.Database;
using VRMS.Enums;
using VRMS.Models.Rentals;

namespace VRMS.Repositories.Rentals;

public class CollateralRepository
{
    // -------------------------------------------------
    // CREATE
    // -------------------------------------------------

    public int Create(
        int rentalId,
        CollateralType type,
        string? description,
        string? referenceNumber,
        DateTime receivedAt)
    {
        var table = DB.Query(
            "CALL sp_collaterals_create(@rid,@type,@desc,@ref,@received);",
            ("@rid", rentalId),
            ("@type", type.ToString()),
            ("@desc", description),
            ("@ref", referenceNumber),
            ("@received", receivedAt)
        );

        return Convert.ToInt32(
            table.Rows[0]["collateral_id"]);
    }

    // -------------------------------------------------
    // UPDATE
    // -------------------------------------------------

    public void MarkReturned(
        int collateralId,
        DateTime returnedAt)
    {
        DB.Execute(
            "CALL sp_collaterals_return(@id,@returned);",
            ("@id", collateralId),
            ("@returned", returnedAt)
        );
    }

    public void MarkLost(int collateralId)
    {
        DB.Execute(
            "CALL sp_collaterals_mark_lost(@id);",
            ("@id", collateralId)
        );
    }

    // -------------------------------------------------
    // READ
    // -------------------------------------------------

    public Collateral GetById(int collateralId)
    {
        var table = DB.Query(
            "CALL sp_collaterals_get_by_id(@id);",
            ("@id", collateralId)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "Collateral not found.");

        return Map(table.Rows[0]);
    }

    public List<Collateral> GetByRental(int rentalId)
    {
        var result = new List<Collateral>();

        var table = DB.Query(
            "CALL sp_collaterals_get_by_rental(@rid);",
            ("@rid", rentalId)
        );

        foreach (DataRow row in table.Rows)
        {
            result.Add(Map(row));
        }

        return result;
    }

    // -------------------------------------------------
    // MAPPING
    // -------------------------------------------------

    private static Collateral Map(DataRow row)
    {
        return new Collateral
        {
            Id = Convert.ToInt32(row["id"]),
            RentalId = Convert.ToInt32(row["rental_id"]),
            Type = Enum.Parse<CollateralType>(
                row["type"].ToString()!, true),

            Description =
                row["description"] == DBNull.Value
                    ? null
                    : row["description"].ToString(),

            ReferenceNumber =
                row["reference_number"] == DBNull.Value
                    ? null
                    : row["reference_number"].ToString(),

            ReceivedAt =
                Convert.ToDateTime(row["received_at"]),

            ReturnedAt =
                row["returned_at"] == DBNull.Value
                    ? null
                    : Convert.ToDateTime(row["returned_at"]),

            Status = Enum.Parse<CollateralStatus>(
                row["status"].ToString()!, true)
        };
    }
}
