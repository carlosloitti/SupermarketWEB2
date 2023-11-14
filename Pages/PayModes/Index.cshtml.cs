using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB2.Data;
using SupermarketWEB2.Models;

namespace SupermarketWEB2.Pages.PayModes
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<PayMode> PayModes { get; set; } = default!;



        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                PayModes = await _context.PayModes.ToListAsync();
            }

        }
    }
}
