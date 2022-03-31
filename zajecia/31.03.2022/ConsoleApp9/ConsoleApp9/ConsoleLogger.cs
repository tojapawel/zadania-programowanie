using AP.Logger;

internal class ConsoleLogger : LoggerBase {
    public override void SendMessage(string message) {
        Console.WriteLine(message);
    }
}