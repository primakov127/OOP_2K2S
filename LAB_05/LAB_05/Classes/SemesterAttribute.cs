using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05.Classes
{
    class SemesterAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string semester = value.ToString();
                if (semester == "1" || semester == "2" || semester == "12")
                    return true;
                else
                    this.ErrorMessage = "Не выбран семестр";
            }
            return false;
        }
    }
}
