namespace Pokedex
{
  class Program
  {
    static void Main(String[] args)
    {
      Pokewiki pokewiki = new Pokewiki();
      int resp = 100;
      while (resp != 0)
      {
        resp = Menu();
        if (resp == 1)
        {
          pokewiki.ListarPokemons();
        }
        if (resp == 2)
        {
          pokewiki.ListarPokemons();
          Console.Write("Digite o código do pokemon: ");
          int codigo = Convert.ToInt32(Console.ReadLine());
          // pokemon do player
          PokemonPlus pPlayer = pokewiki.Pokemons[codigo];
          // definir o pokemon especifico
          Random r = new Random();
          codigo = r.Next(0, pokewiki.Pokemons.Count);
          PokemonPlus pPC = pokewiki.Pokemons[codigo];
          //Batalhar
          Console.WriteLine("Dados dos participantes");
          Console.WriteLine("Seu pokemon:");
          pPlayer.ExibirDadosPokemonPlus();
          Console.WriteLine("VS");
          Console.WriteLine("Oponente:");
          pPC.ExibirDadosPokemonPlus();
          if (pPlayer.Poder > pPC.Poder)
          {
            Console.WriteLine("Você derrotou o adversário!!! Parabens !!");
          }
          else if (pPlayer.Poder == pPC.Poder)
          {
            Console.WriteLine("Empate na arena !!!");
          }
          else
          {
            Console.WriteLine("Você foi derrotado !!!");
          }
        }
        Console.ReadKey();
        Console.Clear();
      }
    }
    static int Menu()
    {
      Console.WriteLine("Pokedex---Agenda Pokemon");
      Console.WriteLine("0 - Sair da Pokedex");
      Console.WriteLine("1 - ListarPokemons");
      Console.WriteLine("2 - Batalhar");
      Console.WriteLine("O que deseja fazer?");
      int resp = Convert.ToInt32(Console.ReadLine());
      return resp;
    }
  }
}
