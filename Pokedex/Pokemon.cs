namespace Pokedex
{
  public class Pokemon
  {

    public Pokemon()
    {
      this.Nome = "";
      this.Sinopse = "";
    }

    public Pokemon(String nome, String sinopse)
    {
      this.Nome = nome;
      this.Sinopse = sinopse;
    }

    private String nome;
    public String Nome
    {
      get { return nome; }
      set
      {
        String texto = value.ToUpper();
        nome = texto;
      }
    }

    private String sinopse; // Armazena o valor da propriedade Sinopse
    public String Sinopse // representa a caracteristica Sinopse do meu pokemon
    {
      get { return this.sinopse; }
      set { this.sinopse = value.ToUpper(); }
    }



    public void ExibirDadosPokemon()
    {
      Console.WriteLine("Nome do Pokemon: " + this.Nome);
      Console.WriteLine("Descrição do Pokemon: " + this.Sinopse);

    }

    public void ExibirDadosPokemon(Boolean formatado)
    {
      if (formatado == true)
      {
        Console.WriteLine("Pokemon " + this.Nome + ": " + this.Sinopse.ToLower());
      }
      else
      {
        Console.WriteLine("Nome do pokemon: " + this.Nome);
        Console.WriteLine("Descrição do pokemon: " + this.Sinopse);
      }
    }
  }
}
