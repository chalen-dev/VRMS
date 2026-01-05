using Microsoft.Extensions.Configuration;
using VRMS.Database;

namespace VRMS;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
        
        DB.Initialize(config.GetConnectionString("Default"));
        
        // ======== Database Migrations ===================================== //
        /* UNCOMMENT EACH LINE IF USED */
        
        //1. Drop All Tables (for migrating fresh)
        DropTables.Run(DB.ExecuteNonQuery);
        
        //2. Create All Tables
        CreateTables.Run(DB.ExecuteScalar, DB.ExecuteNonQuery);
        
        
        // UNCOMMENT FOR TESTING
        // Stop here. Do NOT start WinForms. 
        return;
        
        ApplicationConfiguration.Initialize();
    }
}