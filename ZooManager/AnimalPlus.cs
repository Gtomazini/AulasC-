namespace ZooManager
{
  public class AnimalPlus : Animal
  {
    public AnimalPlus() : base()
    {
      this.TipoAlimentacao = "";
    }

    public AnimalPlus(String especie, Double peso, String tipoAlimentacao) : base(especie, peso)
    {
      this.TipoAlimentacao = tipoAlimentacao;
    }
    public String TipoAlimentacao { get; set; }

    public void ExibirDados()
    {
      Console.WriteLine("Especie: " + this.Especie);
      Console.WriteLine("Peso: " + this.Peso);
      Console.WriteLine("Alimentação: " + this.TipoAlimentacao);
    }
  }
}
