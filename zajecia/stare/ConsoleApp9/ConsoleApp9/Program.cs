//data i godzina - poziom logowania, klasa, metoda, linijka, message

using AP.Logger;
using AP.Logger.enums;
using AP.NASA;
using AP.NASA.Enums;
using AP.NASA.Steps;
using AP.NASA.Tasks;
using ConsoleApp9.Steps;

var arrayy = new LoggerBase[] {new ConsoleLogger(),new DebugLogger()};
var loggerBase = new LoggerProvider(arrayy);

var logger = new MyLogger(LogLevel.Trace, loggerBase);
var steps = new StepBase[] { new Step1(logger) };
/*var matematyka = new Matematyka(new MyLogger(LogLevel.Trace, loggerBase));
matematyka.Dodawanie(2, 2);*/

var marsRover = new MarsRover(logger);

var taskList = new TasksBase[] { 

    new MoveTasks(logger, 3, Directions.North, steps),
    new DrillTasks(logger, 3, steps),
    new MoveTasks(logger, 3, Directions.South, steps)

};

marsRover.DoTask(taskList);



//jak ktos pogtrzebuje tego pliku ->
//https://github.com/tojapawel/zadania-programowanie/tree/main/zajecia/31.03.2022/ConsoleApp9