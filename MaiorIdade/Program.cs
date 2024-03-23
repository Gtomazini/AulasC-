namespace MaiorIdade
{
  class Program
  {
    static void Main(String[] args)
    {
      Console.WriteLine("Programa de Maioridade");

      int i1 = 0, i2 = 0, i3 = 0;
      Pessoa p1 = new Pessoa();
      Pessoa p2 = new Pessoa();


      // 1º Pessoa
      Console.Write("Digite o nome da 1º pessoa: ");
      p1.Nome = Console.ReadLine();
      Console.Write("Agora digite a idade da 1º pessoa: ");
      p1.Idade = Convert.ToInt32(Console.ReadLine());

      // 2º Pessoa
      Console.Write("Digite o nome da 2º pessoa: ");
      p2.Nome = Console.ReadLine();
      Console.Write("Agora digite a idade da 2º pessoa: ");
      p2.Idade = Convert.ToInt32(Console.ReadLine());

      // 3º Pessoa
      Console.Write("Digite o nome da 3º pessoa: ");
      String nome = Console.ReadLine();
      Console.Write("Agora digite a idade da 3º pessoa: ");
      int idade = Convert.ToInt32(Console.ReadLine());
      Pessoa p3 = new Pessoa(nome, idade);

      //Lógica
      if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
      {
        Console.WriteLine("A pessoa mais velha é: ");
        p1.ExibirDados();
      }
      else
      {
        if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
        {
          Console.WriteLine("A pessoa mais velha é: ");
          p2.ExibirDados();
        }
        else
        {
          if ((p3.Idade > p2.Idade) && (p3.Idade > p1.Idade))
          {
            Console.WriteLine("A pessoa mais velha é: ");
            p3.ExibirDados();
          }
          else
          {
            Console.WriteLine("Não foi possível dizer qual é a pessoa mais velha, por erro de dados ou idades igualadas");
          }
        }
      }
    }
  }
}
