using AP.Logger;
using AP.NASA.Enums;
using AP.NASA.Steps;

namespace ConsoleApp9.Steps;
public class Step1 : StepBase {
    public Step1(MyLogger logger) : base("Test jeden", logger) {
    }

    protected override Status OnMakeStep() {
        Console.WriteLine($"-----------------------Step1---------------");
        return Status.Success;
    }
}

