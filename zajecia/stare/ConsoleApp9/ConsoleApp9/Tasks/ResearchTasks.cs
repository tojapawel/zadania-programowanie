
using AP.Logger;
using AP.NASA.Steps;
using AP.NASA.Tasks;

namespace ConsoleApp9.Tasks {
    internal class ResearchTasks : TasksBase {
        public ResearchTasks(MyLogger logger, StepBase[] steps) : base("Badania", logger, steps) {}

        protected override void OnRun() {
            throw new NotImplementedException();
        }
    }
}
