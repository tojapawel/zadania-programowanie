using AP.Logger;
using AP.NASA.Tasks;

namespace AP.NASA;
    
public class MarsRover {
    private int _energyPercentage = 100;
    private MyLogger _logger;

    public MarsRover(MyLogger logger) {
        _logger = logger;

        _logger.LogInformation("Jestem w konstruktorze lazika marsianskiego.");
    }

    public void DoTask(TasksBase[] tasks) {
        _logger.LogTrace("\n\nStart");

        _logger.LogInformation($"Poziom baterii: {_energyPercentage}");

        foreach (var task in tasks) {
            task.Run();
            _energyPercentage -= task.EnergyRequired;
        }

        _logger.LogInformation($"Poziom baterii: {_energyPercentage}");

        _logger.LogTrace("End\n\n");
    }
}