using Microsoft.Extensions.DependencyInjection;
using VRMS.Database;
using VRMS.Database.Exceptions;
using VRMS.Database.Executors;
using VRMS.Database.Seeders;
using VRMS.Services.Account;

namespace VRMS.Terminal.Commands;

public class FreshCommand : ICommand
{
    public string Name => "fresh";

    public CommandResult Execute(string[] args)
    {
        try
        {
            // 1. Drop & migrate
            Drop.Run(DB.ExecuteRaw);
            Create.Run(DB.QueryRaw, DB.ExecuteRaw);

            // 2. Build DI (same as SeedCommand)
            var services = new ServiceCollection();
            services.AddSingleton<UserService>();

            var provider = services.BuildServiceProvider();

            // 3. Run seeders
            SeederRunner.RunAll(provider);

            return new CommandResult(
                true,
                "Database migrated and seeded successfully."
            );
        }
        catch (SchemaExecutionException ex)
        {
            return new CommandResult(
                false,
                $"""
                 Migration failed.

                 Table: {ex.TableName}
                 Action: {ex.Action}

                 Error:
                 {ex.InnerException?.Message}

                 SQL:
                 {ex.Sql}
                 """
            );
        }
        catch (Exception ex)
        {
            return new CommandResult(
                false,
                $"Fresh failed:\n{ex.Message}"
            );
        }
    }
}