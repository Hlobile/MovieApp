#define Rating
#if Rating
#region snippet_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Data;

namespace MovieApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieAppContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MovieAppContext>>()))
            { 
                //look for any movies
                if (context.Movie.Any())
                {
                    return; //db has been seeded
                }
                #region snippet1

                context.Movie.AddRange(
               new Movie
               {
                   Title = "Lord of the Rings",
                   ReleaseDate = DateTime.Parse("2000-01-12"),
                   Genre = "Adventure",
                   Price = 10.01M,
                   Rating = "R"
               },
                #endregion

               new Movie
               {
                   Title = "Ghostbusters ",
                   ReleaseDate = DateTime.Parse("1984-3-13"),
                   Genre = "Comedy",
                   Price = 8.99M,
                   Rating = "PG"
               },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Price = 3.99M,
                   Rating = "R"
               }
                );

            context.SaveChanges();

        }


        }

    }
}
#endregion
#endif