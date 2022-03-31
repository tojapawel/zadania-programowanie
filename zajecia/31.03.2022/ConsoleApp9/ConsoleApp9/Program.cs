//data i godzina - poziom logowania, klasa, metoda, linijka, message

using AP.Logger;
using AP.Logger.enums;
var arrayy = new LoggerBase[] {new ConsoleLogger(),new DebugLogger()};
var loggerBase = new LoggerProvider(arrayy);

var matematyka = new Matematyka(new MyLogger(LogLevel.Trace, loggerBase));
matematyka.Dodawanie(2, 2);
