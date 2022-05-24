using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Base
{
    public abstract class FormBase
    {
        protected FormBase(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        
        public string[] GetAllFormsError()
        {
            var arrays = new ArrayList();
            arrays.AddRange(GetErrorsForNames(FirstName, "imie", 5));
            arrays.AddRange(GetErrorsForNames(LastName, "Nazwisko", 7));
            arrays.AddRange(GetExternalsErros());

            var result = new string[arrays.Count];
            var index = 0;
            foreach (var item in arrays)
            {
                result[index] = (string)item;
                index++;
            }
            return result;
        }

        protected abstract string[] GetExternalsErros();

        private string[] GetErrorsForNames(string value, string propertyName, byte minLength)
        {
            var arrays = new ArrayList();
            //to sprawdzam czy imie nie jest pustym stringiem czy ma długość min 5
            if (string.IsNullOrEmpty(value))
                return new string[] { $"{propertyName} nie może być puste" };
            if( !value.All(char.IsLetter))
            {
                arrays.Add($"{propertyName} musi zawierać same litery");
            }
            if (value.Length < minLength)
            {
                arrays.Add($"{propertyName} nie może mić mniej niź {minLength} liter");
            }
            if (!char.IsUpper(value, 0))
            {
                arrays.Add($"{propertyName} nie może zaczynać sie z małej litery");

            }

            var result = new string[arrays.Count];
            var index = 0;
            foreach (var item in arrays)
            {
                result[index] = (string)item;
                index++;
            }
            return result;
        }
    }
}
