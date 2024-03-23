namespace INSScalculus
{
  public class Pessoa
  {
    private int anoNascimento;
    public int AnoNascimento
    {
      get { return this.anoNascimento; }
      set { this.anoNascimento = value; }
    }

    private String nome;
    public String Nome
    {
      get { return nome; }
      set { nome = value.ToUpper(); }
    }

    // Continuação da aula
    private int idade;
    public int Idade
    {
      get { return this.idade; }
    }


    public void ExibirDados()
    {
      Console.WriteLine("Nome: " + this.Nome);
      Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
      int idade = this.CalcularIdade();
      Console.WriteLine("Idade: " + idade + " Anos");
    }

    private int CalcularIdade()
    {
      DateTime data = DateTime.Now;
      int ano = data.Year;
      int idade = ano - this.AnoNascimento;
      return idade;
    }




  }
}
