using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNETWebApp.Models
{
    public class ValidNum : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int intValue = (int)value;

            if (intValue >= 0 && intValue <= 100)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Value must be between 0 and 100.");
            }
        }
    }
    public class GradeCalcModel
    {
        //Creates getters and setters for From variable
        [Required]
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100.")]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100.")]
        public int GroupProjects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100.")]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100.")]
        public int Midterm { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100.")]
        public int Final { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100.")]
        public int INTEX { get; set; }
    }
}
