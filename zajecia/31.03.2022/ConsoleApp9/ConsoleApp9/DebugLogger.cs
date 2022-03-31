using AP.Logger;
using System.Diagnostics;

internal class DebugLogger : LoggerBase {
    public override void SendMessage(string message) {
        Debug.WriteLine(message);
    }
}