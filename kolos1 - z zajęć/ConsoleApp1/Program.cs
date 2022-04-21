using ConsoleApp1.Base;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var form = new SchoolForm("Jacek", "PlacekTest", "1234567891");
            var result = new Validation.ValidationService().ValidForm(form);

            result.IsValid = false;
            if (result.IsValid)
            {
                Console.WriteLine("Formularz jest ok");
            }
            else
            {
                Console.WriteLine("Formularz jest nie ok");

            }

        }
    }
}
