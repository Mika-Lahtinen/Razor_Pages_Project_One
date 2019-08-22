using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages_Project_One.Models;

namespace Razor_Pages_Project_One.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Razor_Pages_Project_One.Models.Razor_Pages_Project_OneContext _context;

        public DetailsModel(Razor_Pages_Project_One.Models.Razor_Pages_Project_OneContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
