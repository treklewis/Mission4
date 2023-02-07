using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace FirstASPNETWebApp
{
    sealed public class CustomAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;
            int intValue = (int)value;

            if (intValue >= 0 && intValue <= 100)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
