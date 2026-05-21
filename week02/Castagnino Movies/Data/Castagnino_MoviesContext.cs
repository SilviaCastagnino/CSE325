using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Castagnino_Movies.Models;

namespace Castagnino_Movies.Data
{
    public class Castagnino_MoviesContext : DbContext
    {
        public Castagnino_MoviesContext (DbContextOptions<Castagnino_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Castagnino_Movies.Models.Movie> Movie { get; set; } = default!;
    }
}
