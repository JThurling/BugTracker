﻿namespace Core.Interfaces
{
    public interface ILogging
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
