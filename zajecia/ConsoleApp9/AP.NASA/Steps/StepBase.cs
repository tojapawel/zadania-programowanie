using AP.Logger;
using AP.NASA.Core;
using AP.NASA.Enums;

namespace AP.NASA.Steps;
public abstract class StepBase : NameCore {
    protected StepBase(string taskName, MyLogger logger) : base(taskName, logger) {}

    public void MakeStep() {
        Status = Status.InProgress;
        Status = OnMakeStep();
    }

    protected abstract Status OnMakeStep();
}
