using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieApp.Data.MovieAppContext _context;

        public IndexModel(MovieApp.Data.MovieAppContext context)
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
