namespace AreaRetangulo
{
  public class Retangulo
  {
    public Retangulo()
    {
      this.Altura = 0;
      this.Base = 0;
    }

    //Base retangulo

    private double baseret;
    public double Base
    {
      get { return baseret; }
      set
      {
        if (value >= 0) baseret = value;
        else baseret = 0;
      }
    }

    //Altura retangulo
    private double altret;
    public double Altura
    {
      get { return altret; }
      set
      {
        if (value >= 0) altret = value;
        else altret = 0;
      }
    }

    //Area do Retangulo
    public double Area
    {
      get { return altret * baseret; }
    }

    public void ExibirDados()
    {
      Console.WriteLine("Base: " + this.Base);
      Console.WriteLine("Altura: " + this.Altura);
      Console.WriteLine("Area: " + this.Area);
    }

  }
}
