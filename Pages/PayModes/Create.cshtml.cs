using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB2.Data;
using SupermarketWEB2.Models;

namespace SupermarketWEB2.Pages.PayModes
{
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;

        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]

        public PayMode PayModes { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.PayModes == null || PayModes == null)
            {
                return Page();
            }

            _context.PayModes.Add(PayModes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
