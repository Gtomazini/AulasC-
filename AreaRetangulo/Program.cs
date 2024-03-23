namespace AreaRetangulo
{
  class Program
  {
    static void Main(string[] args)
    {
      Retangulo retangulo = new Retangulo();
      Console.WriteLine("Calcura Area de Um Retangulo");
      Console.Write("Digite as dimensões da base do Retangulo: ");
      retangulo.Base = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite a altura do Retangulo: ");
      retangulo.Altura = Convert.ToDouble(Console.ReadLine());
      retangulo.ExibirDados();
      Console.ReadKey();
    }
  }
}
