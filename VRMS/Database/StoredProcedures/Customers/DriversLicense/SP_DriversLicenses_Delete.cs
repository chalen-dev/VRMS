namespace VRMS.Database.StoredProcedures.Customers.DriversLicense;

public static class SP_DriversLicenses_Delete
{
    public static string Sql() => """
                                  CREATE PROCEDURE sp_drivers_licenses_delete (
                                      IN p_license_id INT
                                  )
                                  BEGIN
                                      DELETE FROM drivers_licenses
                                      WHERE id = p_license_id;
                                  END;
                                  """;
}