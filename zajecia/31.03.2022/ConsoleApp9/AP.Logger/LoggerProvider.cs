using System.Collections;

namespace AP.Logger {
    public class LoggerProvider {
        private LoggerBase[] _loggerBases;

        public LoggerProvider(LoggerBase[] loggerBases) {
            _loggerBases = loggerBases;
        }
        internal void Log(string message) {
            foreach (var item in _loggerBases) {
                ((LoggerBase)item).SendMessage(message);
            }
        }
    }
}
