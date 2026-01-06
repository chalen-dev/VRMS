using System;
using System.Reflection;
using VRMS.Database.Migrations;
using VRMS.Database.Migrations.Tables;

namespace VRMS.Database.DBHelpers.TableExecutors;

public static class CreateExecutor
{
    public static void Execute(
        Action<string> executeNonQuery,
        bool strictMode = true
    )
    {
        var assembly = Assembly.GetAssembly(typeof(M_0001_CreateSchemaInfoTable))
            ?? throw new InvalidOperationException("Failed to locate tables assembly.");

        var tableTypes = assembly
            .GetTypes()
            .Where(t =>
                t.IsClass &&
                t.IsAbstract &&
                t.IsSealed &&
                t.Name.StartsWith("M_") &&
                t.GetMethod("Create", BindingFlags.Public | BindingFlags.Static) != null
            )
            .OrderBy(t => t.Name) // ascending
            .ToList();

        foreach (var type in tableTypes)
        {
            try
            {
                ExecuteMethod(type, "Create", executeNonQuery);
                Console.WriteLine($"[OK] {type.Name}");
            }
            catch (Exception ex)
            {
                HandleError(type, ex, strictMode, "create");
            }
        }
    }

    private static void ExecuteMethod(
        Type tableType,
        string methodName,
        Action<string> executeNonQuery
    )
    {
        var method = tableType.GetMethod(
            methodName,
            BindingFlags.Public | BindingFlags.Static
        ) ?? throw new InvalidOperationException(
            $"{methodName}() not found on {tableType.Name}"
        );

        var sql = method.Invoke(null, null) as string
            ?? throw new InvalidOperationException(
                $"{methodName}() on {tableType.Name} did not return SQL"
            );

        executeNonQuery(sql);
    }

    private static void HandleError(
        Type type,
        Exception ex,
        bool strictMode,
        string action
    )
    {
        var root = ex is TargetInvocationException tie && tie.InnerException != null
            ? tie.InnerException
            : ex;

        Console.WriteLine($"[ERROR] {type.Name} ({action})");
        Console.WriteLine($"        {root.GetType().Name}: {root.Message}");

        if (strictMode)
        {
            throw new InvalidOperationException(
                $"Schema {action} failed at {type.Name}",
                root
            );
        }
    }
}
