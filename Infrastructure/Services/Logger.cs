using Core.Interfaces;
using Serilog;
using Serilog.Core;

namespace Infrastructure.Services
{
    public class Logging : ILogging
    {
        public Logging()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\BugTracker.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public void LogInfo(string message)
        {
            Log.Information(message);
        }

        public void LogWarn(string message)
        {
            Log.Warning(message);
        }

        public void LogDebug(string message)
        {
            Log.Debug(message);
        }

        public void LogError(string message)
        {
            Log.Error(message);
        }
    }
}
