using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB2.Data;
using SupermarketWEB2.Models;

namespace SupermarketWEB2.Pages.PayModes
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;

        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }


        [BindProperty]

        public PayMode PayMode { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.PayModes == null)
            {
                return NotFound();
            }

            var paymode = await _context.PayModes.FindAsync(id);

            if (paymode != null)
            {
                PayMode = paymode;
                _context.PayModes.Remove(paymode);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("./Index");
        }
    }
}
