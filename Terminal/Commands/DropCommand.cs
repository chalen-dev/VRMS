using VRMS.Database;
using VRMS.Database.Exceptions;
using VRMS.Database.Executors;
using Helpers.DirectoryCleaner;

namespace VRMS.Terminal.Commands;

public class DropCommand : ICommand
{
    public string Name => "drop";

    public CommandResult Execute(string[] args)
    {
        try
        {
            Drop.Run(DB.ExecuteRaw);

            // Clean Storage directory (preserve .gitignore)
            Dir.Empty("Storage", ".gitignore");

            return new CommandResult(
                true,
                "Database tables dropped and storage cleaned successfully."
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
    }
}