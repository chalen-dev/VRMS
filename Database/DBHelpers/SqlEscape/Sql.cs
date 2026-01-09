namespace VRMS.Database.DBHelpers.SqlEscape;

public static class Sql
{
    public static string Esc(string input)
        => input.Replace("'", "''");
}
