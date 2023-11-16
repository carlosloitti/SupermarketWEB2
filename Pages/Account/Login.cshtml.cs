using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB2.Models;

namespace SupermarketWEB2.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult>OnPostAsync () {

            if (!ModelState.IsValid) return Page();

            if (User.Email == "correo@gmail.com" && User.Password == "12345" )  
            {
                return RedirectToPage("/index");
            }
            return Page();
        }
    }
}
