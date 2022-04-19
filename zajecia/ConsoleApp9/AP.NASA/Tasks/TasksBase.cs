using AP.Logger;
using AP.NASA.Core;
using AP.NASA.Enums;
using AP.NASA.Steps;

namespace AP.NASA.Tasks;
abstract public class TasksBase : NameCore{
    private StepBase[] _steps;

    public TasksBase(string taskName, MyLogger logger, StepBase[] steps) 
        :base(taskName, logger) {
        _steps = steps;
    }

    public int EnergyRequired { get; protected set; }

    public void Run() {
        Status = Status.InProgress;
        _logger.LogTrace($"{_taskName} start.");

        foreach (var step in _steps) {
            step.MakeStep();
        }

        _logger.LogTrace($"{_taskName} ended with status: {Status}.\n");
    }

    abstract protected void OnRun();
}
