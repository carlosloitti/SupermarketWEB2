using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB2.Data;
using SupermarketWEB2.Models;

namespace SupermarketWEB2.Pages.Categories
{
    public class IndexModel : PageModel
    {

        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Category> Categories { get; set; } = default!;

         

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Categories = await _context.Categories.ToListAsync();
            }

        }
    }
}
