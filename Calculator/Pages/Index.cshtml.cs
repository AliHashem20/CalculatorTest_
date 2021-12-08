using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Pages
{
    public class IndexModel : PageModel
    {

        public Services services;
        public IndexModel( Services s)
        {
            services = s;
        }

        [BindProperty]
        public UserIputs userIputs { get; set; }

        public void OnGet()
        {
        }

        public int nb1;
        public int nb2;
        public String op;
        public int res;
        public String[] tab;


        public IActionResult OnPost() 
        {
            if (userIputs.numbers != null)
            {
                tab = userIputs.numbers.Split(' ');
                if (tab.Length != 3)
                {
                    ModelState.AddModelError("", "The form is not valid, you must follow the syntax mentioned!");
                }
                else if (!int.TryParse(tab[0], out nb1) || !int.TryParse(tab[2], out nb2) || !services.checkOp(tab[1]))
                {
                    ModelState.AddModelError("", "There is an error, you must put 2 numbers and an operator");
                }
            }
            
            if (!ModelState.IsValid)
                return Page();

            nb1 = int.Parse(tab[0]);
            nb2 = int.Parse(tab[2]);

            res = services.getResult(nb1, nb2, tab[1]);

            userIputs.result = userIputs.numbers + " = " + res;

            return Page();

        }


    }

    

    


}
