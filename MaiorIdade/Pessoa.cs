namespace MaiorIdade
{
  class Pessoa
  {

    //Construtores
    public Pessoa()
    {
      this.Nome = "";
      this.Idade = 0;
    }

    public Pessoa(String nome, int idade)
    {
      this.Nome = nome;
      this.Idade = idade;
    }

    //Propriedades
    private String nome;
    public String Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    private int idade;
    public int Idade
    {
      get { return idade; }
      set
      {
        if (value >= 0)
        {
          idade = value;
        }
        else
        {
          this.idade = 0;
        }
      }
    }

    // Metodos
    public void ExibirDados()
    {
      Console.WriteLine("Nome:" + this.Nome);
      Console.WriteLine("Idade" + this.Idade);
    }

  }
}
