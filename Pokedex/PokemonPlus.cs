namespace Pokedex
{
  public class PokemonPlus : Pokemon
  {
    public PokemonPlus() : base()
    {
      this.Poder = 0;
    }


    public PokemonPlus(String nome, String sinopse, int poder) : base(nome, sinopse)
    {
      this.Poder = poder;
    }
    public int Poder { get; set; }

    public void ExibirDadosPokemonPlus()
    {
      Console.WriteLine("Nome do Pokemon: " + this.Nome);
      Console.WriteLine("Descrição do Pokemon: " + this.Sinopse);
      Console.WriteLine("Poder: " + this.Poder);
    }
  }
}
