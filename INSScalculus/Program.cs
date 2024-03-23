namespace INSScalculus
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Programa que calcula a idade do usuário");
      Pessoa p = new Pessoa();
      Console.WriteLine("Digite o seu nome: ");
      p.Nome = Console.ReadLine();
      Console.WriteLine("Digite o ano de nascimento: ");
      p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
      p.ExibirDados();

    }
  }
}
