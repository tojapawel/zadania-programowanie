using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Base
{
    public class SchoolForm : FormBase
    {
        public SchoolForm(string firstName, string lastName, string pesel) 
            : base(firstName, lastName)
        {
            Pesel = pesel;
        }

        public string Pesel { get; }

        protected override string[] GetExternalsErros()
        {
            if(string.IsNullOrEmpty(Pesel))
            {
                return new string[] { "Pesel nie moze byc pusty" };
            }

            return new string[0];
        }
    }
}
