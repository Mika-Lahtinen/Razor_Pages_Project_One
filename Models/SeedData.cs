using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Razor_Pages_Project_One.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Razor_Pages_Project_OneContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Razor_Pages_Project_OneContext>>()))
            {
                //Looking for movies
                if (context.Movie.Any())
                {
                    return; //Seed exists.
                }

                context.Movie.AddRange(
                   new Movie
                   {
                       Title = "When Harry Met Sally",
                       ReleaseDate = DateTime.Parse("1989-2-12"),
                       Genre = "Romantic Comedy",
                       Price = 7.99M,
                       Rating = "E"
                   },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "E"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "E"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "E"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
