namespace VRMS.Database.EnumSqlHelper;

public static class Tbl
{
    public static string ToEnum<T>() where T : Enum
    {
        var values = Enum.GetNames(typeof(T))
            .Select(v => $"'{v}'");

        return $"ENUM({string.Join(",", values)})";
    }
}
