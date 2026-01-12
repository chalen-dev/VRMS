using VRMS.Database.SPImplementations.Reports;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1023_CreateReportProcedures
{
    public static string Create() => $"""
                                          {SP_Report_FleetUtilization.Sql()}
                                          {SP_Report_Revenue.Sql()}
                                          {SP_Report_Kpis.Sql()}
                                      """;

    public static string Drop() => """
                                       DROP PROCEDURE IF EXISTS sp_report_fleet_utilization;
                                       DROP PROCEDURE IF EXISTS sp_report_revenue;
                                       DROP PROCEDURE IF EXISTS sp_report_kpis;
                                   """;
}