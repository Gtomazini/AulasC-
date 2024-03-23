namespace ZooManager
{
  class Program
  {
    static void Main(string[] args)
    {
      List<AnimalPlus> animais = new List<AnimalPlus>();
      int countCar = 0, countHer = 0;
      Console.WriteLine("Gerenciador da alimentação dos animais");
      for (int i = 0; i < 4; i++)
      {
        AnimalPlus animal = new AnimalPlus();
        Console.Write("Especie: ");
        animal.Especie = Console.ReadLine();
        Console.Write("Peso: ");
        animal.Peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Tipo de alimentação: ");
        animal.TipoAlimentacao = Console.ReadLine();
        if (animal.TipoAlimentacao == "Carnivoro")
        {
          //Carnivoro
          countCar++;
        }
        else
        {
          if (animal.TipoAlimentacao == "Herbivoro")
          {
            countHer++;
          }
          else
          {
            Console.WriteLine("Tipo inválido");
          }
        }
        animais.Add(animal);
      }
      Console.WriteLine("Total de animais carnivoros: " + countCar);
      Console.WriteLine("Total de animais herbivoros: " + countHer);
      Console.ReadKey();
    }
  }
}
