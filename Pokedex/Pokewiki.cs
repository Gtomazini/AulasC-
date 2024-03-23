namespace Pokedex
{
  public class Pokewiki
  {
    public Pokewiki()
    {
      this.IniciaLista();
    }

    private List<PokemonPlus> pokemons;

    public List<PokemonPlus> Pokemons
    {
      get { return pokemons; }
    }

    private void IniciaLista()
    {
      // Instanciar a lista
      this.pokemons = new List<PokemonPlus>();
      PokemonPlus p = new PokemonPlus("Bulbassaro", "Sua sinopse", 100);
      this.pokemons.Add(p);
      p = new PokemonPlus("Pikachu", "tipo raio", 40);
      this.pokemons.Add(p);
    }

    public void ListarPokemons()
    {
      for (int i = 0; i < this.Pokemons.Count; i++)
      {
        Console.WriteLine("Código do pokemon: " + i);
        this.Pokemons[i].ExibirDadosPokemon();
      }
    }

  }
}
