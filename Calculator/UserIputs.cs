using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserIputs
    {
        [Required(ErrorMessage ="This field is required")]
        [Display(Name = "Put your equation as mentioned inside the input here: ")]
        public String numbers { get; set; }
        public String result { get; set; }
    }
}
