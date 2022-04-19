using System.Diagnostics;
using System.Runtime.CompilerServices;

using AP.Logger.enums;

namespace AP.Logger {
    public class MyLogger {
        private LogLevel _logLevel;
        private LoggerProvider _loggerProvider;

        public MyLogger(LogLevel logLevel, LoggerProvider loggerProvider) {
            _logLevel = logLevel;
            _loggerProvider = loggerProvider;
        }

        public void LogInformation(string message,[CallerFilePath] string originClass="", [CallerMemberName]string originMethod="", [CallerLineNumber] int lineNumber=0 ) {
            Log(MessageFormat(message, originClass, originMethod, lineNumber), LogLevel.Information);
        }

        public void LogError(string message, [CallerFilePath] string originClass = "", [CallerMemberName] string originMethod = "", [CallerLineNumber] int lineNumber = 0) {
            Log(MessageFormat(message, originClass, originMethod, lineNumber), LogLevel.Error);
        }
        public void LogTrace(string message, [CallerFilePath] string originClass = "", [CallerMemberName] string originMethod = "", [CallerLineNumber] int lineNumber = 0) {
            Log(MessageFormat(message, originClass, originMethod, lineNumber), LogLevel.Trace);
        }

        public void LogDebug(string message, [CallerFilePath] string originClass = "", [CallerMemberName] string originMethod = "", [CallerLineNumber] int lineNumber = 0) {
            Log(MessageFormat(message, originClass, originMethod, lineNumber), LogLevel.Debug);
        }

        public void LogWarning(string message, [CallerFilePath] string originClass = "", [CallerMemberName] string originMethod = "", [CallerLineNumber] int lineNumber = 0) {
            Log(MessageFormat(message, originClass, originMethod, lineNumber), LogLevel.Warning);
        }

        public void LogCritical(string message, [CallerFilePath] string originClass = "", [CallerMemberName] string originMethod = "", [CallerLineNumber] int lineNumber = 0) {
            Log(MessageFormat(message, originClass, originMethod, lineNumber), LogLevel.Critical);
        }

        private void Log(string message, LogLevel level) {
            if (_logLevel <= level) {
                message = $"{DateTime.Now} - {level}, {message}";

                _loggerProvider.Log(message);
            }
        }

        private string MessageFormat(string message, string originClass = "", string originMethod = "", int lineNumber = 0) {
            return "class: " + originClass + " - " + "method: " + originMethod + " - " + "line number: " + lineNumber + "\n" + "message:" + message;
        }
    }
}


//data i godzina - poziom logowania, klasa, metoda, linijka, message