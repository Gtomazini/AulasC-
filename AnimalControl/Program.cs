namespace AnimalControl
{
  class Program
  {
    static void Main(String[] args)
    {
      Animal a1 = new Animal();
      Animal a2 = new Animal();
      Animal a3 = new Animal();
      Animal a4 = new Animal();
      Animal a5 = new Animal();

      int tlCachorro = 0, tlGato = 0, tlPeixe = 0;


      Console.WriteLine("Controle de Animais");
      // Primeiro Animal
      Console.Write("Informe o nome do 1º animal: ");
      a1.Nome = Console.ReadLine();
      Console.Write("Tipo do 1º Animal (Cachorro, Gato ou Peixe): ");
      a1.Tipo = Console.ReadLine();

      if (a1.Tipo == "Cachorro") tlCachorro++;
      if (a1.Tipo == "Gato") tlGato++;
      if (a1.Tipo == "Peixe") tlPeixe++;


      // Segundo Animal
      Console.Write("Informe o nome do 2º animal: ");
      a2.Nome = Console.ReadLine();
      Console.Write("Tipo do 2º Animal (Cachorro, Gato ou Peixe): ");
      a2.Tipo = Console.ReadLine();

      if (a2.Tipo == "Cachorro") tlCachorro++;
      if (a2.Tipo == "Gato") tlGato++;
      if (a2.Tipo == "Peixe") tlPeixe++;


      // Terceiro Animal
      Console.Write("Informe o nome do 3º animal: ");
      a3.Nome = Console.ReadLine();
      Console.Write("Tipo do 3º Animal (Cachorro, Gato ou Peixe): ");
      a3.Tipo = Console.ReadLine();

      if (a3.Tipo == "Cachorro") tlCachorro++;
      if (a3.Tipo == "Gato") tlGato++;
      if (a3.Tipo == "Peixe") tlPeixe++;
      if (a3.Tipo != "Cachorro" && a3.Tipo != "Gato" && a3.Tipo != "Peixe") tlPeixe++;

      // Quarto Animal
      Console.Write("Informe o nome do 4º animal: ");
      a4.Nome = Console.ReadLine();
      Console.Write("Tipo do 4º Animal (Cachorro, Gato ou Peixe): ");
      a4.Tipo = Console.ReadLine();

      if (a4.Tipo == "Cachorro") tlCachorro++;
      if (a4.Tipo == "Gato") tlGato++;
      if (a4.Tipo == "Peixe") tlPeixe++;


      // Quinto Animal
      Console.Write("Informe o nome do 5º animal: ");
      a5.Nome = Console.ReadLine();
      Console.Write("Tipo do 5º Animal (Cachorro, Gato ou Peixe): ");
      a5.Tipo = Console.ReadLine();
      if (a5.Tipo == "Cachorro") tlCachorro++;
      if (a5.Tipo == "Gato") tlGato++;
      if (a5.Tipo == "Peixe") tlPeixe++;


      // Resultado
      //
      Console.WriteLine("Total de Animais");
      Console.WriteLine("Cachorros: " + tlCachorro + "\nGatos: " + tlGato + "\nPeixes: " + tlPeixe);
      Console.ReadKey();


    }
  }
}
