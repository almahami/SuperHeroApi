using SuperHeroApi.Models;

namespace SuperHeroApi.Data;

public class Query
{
  public IQueryable<Superhero> GetSuperheroes =>
    new List<Superhero>().AsQueryable();
}