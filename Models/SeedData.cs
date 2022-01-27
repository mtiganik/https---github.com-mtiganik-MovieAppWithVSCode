using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Models;
using System;
using System.Linq;

namespace MovieApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                if(!context.Category.Any()){
                     context.Category.AddRange(
                         new Category{
                             Name= "Comedy"
                         },
                         new Category{
                             Name="Romantic Comedy"
                         },
                         new Category{
                            Name="Western"
                        }
                     );
                     context.SaveChanges();
                }
               

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Year = 1989,
                        Description="When Harry Met Sally... is a 1989 American romantic comedy film written by Nora Ephron and directed by Rob Reiner. It stars Billy Crystal as Harry and Meg Ryan as Sally. The story follows the title characters from the time they meet in Chicago just before sharing a cross-country drive, through twelve years of chance encounters in New York City. The film addresses but fails to resolve questions along the lines of 'Can men and women ever just be friends?'",
                        Rating=90,
                        CategoryId = 2,
                        
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        Year = 1984,
                        Description="Ghostbusters is a 1984 American supernatural comedy film directed and produced by Ivan Reitman and written by Dan Aykroyd and Harold Ramis. It stars Bill Murray, Aykroyd and Ramis as Peter Venkman, Ray Stantz and Egon Spengler, three eccentric parapsychologists who start a ghost-catching business in New York City.",
                        Rating=75,
                        CategoryId=1
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Year = 1986,
                        Description="Having gone bankrupt and out of work, the Ghostbusters have now retired. But their services are required again when a series of events involving ectoplasmic slime threaten the city and Dana's baby.",
                        CategoryId = 1,
                        Rating=85
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        Year = 1959,
                        Description="Rio Bravo is a 1959 American Western film produced and directed by Howard Hawks and starring John Wayne, Dean Martin, Ricky Nelson, Angie Dickinson, Walter Brennan, and Ward Bond. Written by Jules Furthman and Leigh Brackett, based on the short story 'Rio Bravo' by B. H. McCampbell, the film stars Wayne as a Texan sheriff who arrests the brother of a powerful local rancher for murder and then has to hold the man in jail until a U.S. Marshal can arrive. With the help of a 'cripple', a drunk and a young gunfighter, they hold off the rancher's gang. Rio Bravo was filmed on location at Old Tucson Studios outside Tucson, Arizona, in Technicolor.",
                        CategoryId = 3,
                        Rating=65
                    }
                );
                context.SaveChanges();
            }
        }
    }
}