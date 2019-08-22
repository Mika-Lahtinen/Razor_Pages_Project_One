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
    public class IndexModel : PageModel
    {
        private readonly Razor_Pages_Project_One.Models.Razor_Pages_Project_OneContext _context;

        public IndexModel(Razor_Pages_Project_One.Models.Razor_Pages_Project_OneContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
