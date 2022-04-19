namespace AP.NASA.Tasks;
using AP.NASA.Enums;
using AP.Logger;
using AP.NASA.Steps;

public class MoveTasks : TasksBase{
    private int _distance;
    private Directions _direction;

    public MoveTasks(MyLogger logger, int distance, Directions direction, StepBase[] steps) 
        :base ("Jedz", logger, steps){
        _distance = distance;

        EnergyRequired = distance * 2;

        _direction = direction;

        _logger.LogInformation("Jestem w konstruktorze MoveTasks.");
    }

    protected override void OnRun() {

        Thread.Sleep(2000);
        var rng = new Random();
        var result = rng.Next(1, 20);


        Status = result>18? Status.Failed: Status.Success;

    }
}
