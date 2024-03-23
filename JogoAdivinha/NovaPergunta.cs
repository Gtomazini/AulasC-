namespace JogoAdivinha
{
  public class NovaPergunta : PerguntaJogo
  {

    public NovaPergunta() : base()
    {
      this.Dica = "";

    }

    public NovaPergunta(String pergunta, String resposta, String dica) : base(pergunta, resposta)
    {
      this.Dica = dica;

    }

    private String dica;
    public String Dica
    {
      get { return dica; }
      set { dica = value.ToUpper(); }
    }

  }
}
