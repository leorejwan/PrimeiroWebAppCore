using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegracaoCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntegracaoCore.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Index", new { Address.City });
        }
    }
}
