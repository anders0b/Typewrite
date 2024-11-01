using DbUp;
using Microsoft.Extensions.Logging;

namespace Typewrite.Infrastructure;

public static class MigrationHelper
{
    public static void EnsureDatabaseIsAvailableAndUpToDate(string connectionString, ILogger logger)
    {
        EnsureDatabase.For.SqlDatabase(connectionString);
        var upgradeEngine = 
            DeployChanges.To
            .SqlDatabase(connectionString)
            .WithScriptsEmbeddedInAssembly(typeof(MigrationHelper).Assembly)
            .LogToAutodetectedLog()
            .Build();
        if(upgradeEngine.GetScriptsToExecute().Any())
        {
            foreach(var script in upgradeEngine.GetScriptsToExecute())
            {
                logger.LogInformation($"Executing script: {script.Name}");
            }
            var dbUpgradeResult = upgradeEngine.PerformUpgrade();
            if(!dbUpgradeResult.Successful)
            {
                logger.LogError("Database upgrade failed");
                throw new Exception($"Database upgrade failed {dbUpgradeResult.Error.Message}", dbUpgradeResult.Error);
            }
        }
    }
}
