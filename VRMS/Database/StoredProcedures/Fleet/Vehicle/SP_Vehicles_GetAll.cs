namespace VRMS.Database.StoredProcedures.Fleet.Vehicle;

public static class SP_Vehicles_GetAll
{
    public static string Sql() => """
                                  CREATE PROCEDURE sp_vehicles_get_all ()
                                  BEGIN
                                      SELECT *
                                      FROM vehicles
                                      WHERE status <> 'Retired'
                                      ORDER BY vehicle_code;
                                  END;
                                  """;
}