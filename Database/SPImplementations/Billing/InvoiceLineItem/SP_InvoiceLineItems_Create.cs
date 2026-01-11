namespace VRMS.Database.SPImplementations.Billing.InvoiceLineItem;

public static class SP_InvoiceLineItems_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_invoice_line_items_create;

                                  CREATE PROCEDURE sp_invoice_line_items_create (
                                      IN p_invoice_id INT,
                                      IN p_description VARCHAR(255),
                                      IN p_amount DECIMAL(10,2)
                                  )
                                  BEGIN
                                      INSERT INTO invoice_line_items (
                                          invoice_id,
                                          description,
                                          amount
                                      )
                                      VALUES (
                                          p_invoice_id,
                                          p_description,
                                          p_amount
                                      );
                                  END;
                                  """;
}