using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages_Project_One.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }

        [BindProperty(SupportsGet =true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            //添加LINQ选择电影流派
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            //添加LINQ搜索电影条目
            var movies = from m in _context.Movie
                        select m;
            if(!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
