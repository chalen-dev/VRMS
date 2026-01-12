using System.Data;
using VRMS.Database;
using VRMS.DTOs.Reports;

namespace VRMS.Repositories.Reports;

public class ReportsRepository
{
    // =====================================================
    // FLEET UTILIZATION
    // =====================================================

    public IReadOnlyList<FleetUtilizationRowDto>
        GetFleetUtilization(DateTime from, DateTime to)
    {
        var table = DB.Query(
            "CALL sp_report_fleet_utilization(@from,@to);",
            ("@from", from.Date),
            ("@to", to.Date)
        );

        var list = new List<FleetUtilizationRowDto>();

        foreach (DataRow r in table.Rows)
        {
            list.Add(new FleetUtilizationRowDto
            {
                VehicleId =
                    Convert.ToInt32(r["vehicle_id"]),

                VehicleCode =
                    r["vehicle_code"].ToString()!,

                MakeModel =
                    r["make_model"].ToString()!,

                DaysRented =
                    Convert.ToInt32(r["days_rented"]),

                TotalDays =
                    Convert.ToInt32(r["total_days"]),

                UtilizationPercent =
                    Convert.ToDecimal(r["utilization_percent"])
            });
        }

        return list;
    }

    // =====================================================
    // REVENUE
    // =====================================================

    public IReadOnlyList<RevenueReportRowDto>
        GetRevenueReport(DateTime from, DateTime to)
    {
        var table = DB.Query(
            "CALL sp_report_revenue(@from,@to);",
            ("@from", from.Date),
            ("@to", to.Date)
        );

        var list = new List<RevenueReportRowDto>();

        foreach (DataRow r in table.Rows)
        {
            list.Add(new RevenueReportRowDto
            {
                InvoiceId =
                    Convert.ToInt32(r["invoice_id"]),

                RentalId =
                    Convert.ToInt32(r["rental_id"]),

                VehicleCode =
                    r["vehicle_code"].ToString()!,

                InvoiceDate =
                    Convert.ToDateTime(r["invoice_date"]),

                Amount =
                    Convert.ToDecimal(r["amount"]),

                IsPaid =
                    Convert.ToInt32(r["is_paid"]) == 1
            });
        }

        return list;
    }

    // =====================================================
    // KPIs
    // =====================================================

    public KpiReportDto GetKpis(
        DateTime from,
        DateTime to)
    {
        var table = DB.Query(
            "CALL sp_report_kpis(@from,@to);",
            ("@from", from.Date),
            ("@to", to.Date)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "KPI report returned no data.");

        var r = table.Rows[0];

        return new KpiReportDto
        {
            TotalVehicles =
                Convert.ToInt32(r["total_vehicles"]),

            TotalRentals =
                Convert.ToInt32(r["total_rentals"]),

            TotalRentalDays =
                Convert.ToInt32(r["total_rental_days"]),

            TotalRevenue =
                Convert.ToDecimal(r["total_revenue"]),

            AverageRentalDurationDays =
                Convert.ToDecimal(r["avg_rental_duration"]),

            FleetUtilizationPercent =
                Convert.ToDecimal(r["fleet_utilization_percent"]),

            DamageIncidentCount =
                Convert.ToInt32(r["damage_incident_count"])
        };
    }
}
