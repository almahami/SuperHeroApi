using SuperHeroApi.Models;

namespace SuperHeroApi.Data;

public class Query
{
  [UseProjection]
  [UseFiltering]
  [UseSorting]
  public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
    context.Superheroes;
  
  [UseProjection]
  [UseFiltering]
  [UseSorting]
  public IQueryable<Superpower> Superpowers([Service] ApplicationDbContext context) =>
    context.Superpowers;
  
  [UseProjection]
  [UseFiltering]
  [UseSorting]
  public IQueryable<Movie> GetMovies([Service] ApplicationDbContext context) =>
    context.Movies;
}