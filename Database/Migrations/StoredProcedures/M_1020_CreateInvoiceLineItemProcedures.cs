using VRMS.Database.SPImplementations.Billing.InvoiceLineItem;

namespace VRMS.Database.Migrations;

public static class M_1020_CreateInvoiceLineItemProcedures
{
    public static string Create() => $"""
                                      {SP_InvoiceLineItems_Create.Sql()}
                                      {SP_InvoiceLineItems_GetByInvoice.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_invoice_line_items_create;
                                   DROP PROCEDURE IF EXISTS sp_invoice_line_items_get_by_invoice;
                                   """;
}