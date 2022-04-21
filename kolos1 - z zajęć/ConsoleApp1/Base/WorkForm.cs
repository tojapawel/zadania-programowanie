namespace ConsoleApp1.Base
{
    public class WorkForm : FormBase
    {
        public WorkForm(string firstName, string lastName, int age) : base(firstName, lastName)
        {
            Age = age;
        }

        public int Age { get; }

        protected override string[] GetExternalsErros() 
        {

            if (Age < 18 || Age > 65)
                return new string[] { "Wiek nie może byc ...." };
            return null;
        }
    }
}
