using System;
using System.ComponentModel.DataAnnotations;

namespace Mission3Assignment.Models
{
    public class CalculatorModel
    {
        [Required]
        //this is the field in the Calculator form for
        public int Assignment { get; set; } // this last part in curly braces does what the bottom ones would do! 

        [Required]
        //this is the field in the Calculator form for
        public int Group { get; set; } // this last part in curly braces does what the bottom ones would do! 

        [Required]
        //this is the field in the Calculator form for
        public int Quiz { get; set; } // this last part in curly braces does what the bottom ones would do! 

        [Required]
        //this is the field in the Calculator form for
        public int Exam { get; set; } // this last part in curly braces does what the bottom ones would do! 

        [Required]
        //this is the field in the Calculator form for
        public int Intex { get; set; } // this last part in curly braces does what the bottom ones would do! 




    }
}
