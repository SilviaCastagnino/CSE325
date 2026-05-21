using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Castagnino_Movies.Models;

public class MovieGenreViewModel
{
  public List<Movie>? Movies { get; set; }
  public SelectList? Genres { get; set; }
  public SelectList? Year { get; set; }
  public string? MovieGenre { get; set; }
  public string? MovieYear { get; set; }
  public string? SearchString { get; set; }
}