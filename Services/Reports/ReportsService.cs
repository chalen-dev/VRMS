using VRMS.DTOs.Reports;
using VRMS.Repositories.Reports;

namespace VRMS.Services.Reports;

public class ReportsService
{
    private readonly ReportsRepository _repo;

    public ReportsService(ReportsRepository repo)
    {
        _repo = repo;
    }

    // =====================================================
    // FLEET UTILIZATION
    // =====================================================

    public IReadOnlyList<FleetUtilizationRowDto>
        GetFleetUtilization(DateTime from, DateTime to)
    {
        ValidateDateRange(from, to);
        return _repo.GetFleetUtilization(from, to);
    }

    // =====================================================
    // REVENUE
    // =====================================================

    public IReadOnlyList<RevenueReportRowDto>
        GetRevenueReport(DateTime from, DateTime to)
    {
        ValidateDateRange(from, to);
        return _repo.GetRevenueReport(from, to);
    }

    // =====================================================
    // KPIs
    // =====================================================

    public KpiReportDto GetKpis(
        DateTime from,
        DateTime to)
    {
        ValidateDateRange(from, to);
        return _repo.GetKpis(from, to);
    }

    // =====================================================
    // INTERNAL
    // =====================================================

    private static void ValidateDateRange(
        DateTime from,
        DateTime to)
    {
        if (to < from)
            throw new InvalidOperationException(
                "End date cannot be earlier than start date.");
    }
}