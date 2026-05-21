using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Castagnino_Movies.Data;
using System;
using System.Linq;

namespace Castagnino_Movies.Models;

public static class SeedData
{
  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var context = new Castagnino_MoviesContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<Castagnino_MoviesContext>>()))
    {
      // Look for any movies.
      if (context.Movie.Any())
      {
        return;   // DB has been seeded
      }
      context.Movie.AddRange(
          new Movie
          {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-2-12"),
            Genre = "Romantic Comedy",
            Rating = "R",
            Price = 7.99M
          },
          new Movie
          {
            Title = "Ghostbusters ",
            ReleaseDate = DateTime.Parse("1984-3-13"),
            Genre = "Comedy",
            Rating = "R",
            Price = 8.99M
          },
          new Movie
          {
            Title = "Ghostbusters 2",
            ReleaseDate = DateTime.Parse("1986-2-23"),
            Genre = "Comedy",
            Rating = "R",
            Price = 9.99M
          },
          new Movie
          {
            Title = "Rio Bravo",
            ReleaseDate = DateTime.Parse("1959-4-15"),
            Genre = "Western",
            Rating = "R",
            Price = 3.99M
          },
          new Movie
          {
            Title = "La La Land",
            ReleaseDate = DateTime.Parse("2016-8-31"),
            Genre = "Musical",
            Rating = "R",
            Price = 30M
          },
          new Movie
          {
            Title = "Beatiful Creatures",
            ReleaseDate = DateTime.Parse("2013-1-11"),
            Genre = "Musical",
            Rating = "R",
            Price = 60M
          },
          new Movie
          {
            Title = "50 First Dates",
            ReleaseDate = DateTime.Parse("2004-4-15"),
            Genre = "Commedy",
            Rating = "R",
            Price = 30M
          }
      );
      context.SaveChanges();
    }
  }
}