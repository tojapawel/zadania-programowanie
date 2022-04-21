using ConsoleApp1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Validation
{
    public class ValidationResult
    {
        public ValidationResult(string[] errors)
        {
            Errors = errors;
            IsValid = false;
        }

        public ValidationResult()
        {
            IsValid = true;
        }

        public bool IsValid { get;  }

        public string[] Errors { get; }
    }

    public class ValidationService
    {
        public ValidationResult ValidForm(FormBase form)
        {

            var result = form.GetAllFormsError();
            if (result != null && result.Length > 0)
            {
                return new ValidationResult(result);
            }
            return new ValidationResult();
        }
    }
}
