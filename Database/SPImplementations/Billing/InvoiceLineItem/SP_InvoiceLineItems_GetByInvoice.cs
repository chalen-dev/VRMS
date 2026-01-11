namespace VRMS.Database.SPImplementations.Billing.InvoiceLineItem;

public static class SP_InvoiceLineItems_GetByInvoice
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_invoice_line_items_get_by_invoice;

                                  CREATE PROCEDURE sp_invoice_line_items_get_by_invoice (
                                      IN p_invoice_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          invoice_id,
                                          description,
                                          amount
                                      FROM invoice_line_items
                                      WHERE invoice_id = p_invoice_id;
                                  END;
                                  """;
}