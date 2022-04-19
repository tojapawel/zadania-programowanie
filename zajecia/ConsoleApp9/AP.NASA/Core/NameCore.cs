using AP.Logger;
using AP.NASA.Enums;

namespace AP.NASA.Core;
abstract public class NameCore {
    protected readonly string _taskName;
    protected MyLogger _logger;

    protected NameCore(string taskName, MyLogger logger) {
        _taskName = taskName;
        _logger = logger;
    }

    public Status Status { get; protected set; } = Status.Waiting;
}
