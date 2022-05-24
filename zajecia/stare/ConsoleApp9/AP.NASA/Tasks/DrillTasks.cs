namespace AP.NASA.Tasks;
using AP.NASA.Enums;
using AP.Logger;
using AP.NASA.Steps;

public class DrillTasks : TasksBase{
    private int _depth;

    public DrillTasks(MyLogger logger, int depth, StepBase[] steps)
        :base ("Wierc", logger, steps){
        _depth = depth;

        EnergyRequired = _depth * 4;

        _logger.LogInformation("Jestem w konstruktorze DrillTasks.");
    }

    

    protected override void OnRun() {

        var rng = new Random();
        var result = rng.Next(1, 10);

        if (result == 1) {
            Status = Status.Canceled;
        } else {
            Status = result > 7 ? Status.Success : Status.Failed;
        }

    }
}
