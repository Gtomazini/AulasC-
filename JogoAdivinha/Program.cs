namespace JogoAdivinha
{
  class Program
  {
    static void Main(String[] args)
    {
      // Lista de perguntas
      List<NovaPergunta> perguntas;
      perguntas = CriarPerguntas();
      Random r = new Random();
      int pos = r.Next(0, perguntas.Count);
      NovaPergunta pergunta = perguntas[pos];
      int tentativas = 0;
      Boolean flag = false;
      String resposta = "";
      while (tentativas <= 3 && flag == false)
      {
        Console.WriteLine("Pergunta: " + pergunta.Pergunta);
        Console.Write("Resposta: ");
        resposta = Console.ReadLine();
        resposta = resposta.ToUpper();
        if (resposta == pergunta.Resposta)
        {
          flag = true;
        }
        else
        {
          Console.WriteLine("Errou ! Dica: " + pergunta.Dica);
        }
        tentativas++;
      }
      if (flag == true)
      {
        Console.WriteLine("Parabéns!!! Você acertou.");
      }
      else
      {
        Console.WriteLine("Que pena !!!  Você Perdeu o Jogo");
      }
      Console.ReadKey();
    }
    static List<NovaPergunta> CriarPerguntas()
    {
      List<NovaPergunta> lista = new List<NovaPergunta>();
      lista.Add(new NovaPergunta("Aplicativo de assistir filmes", "Netflix", "App de streaming mais hypado"));
      lista.Add(new NovaPergunta("Qual a cor do céu?", "Azul", "Começa com a letra A"));
      lista.Add(new NovaPergunta("Maior buscador da internet", "Google", "Nome com G"));
      lista.Add(new NovaPergunta("Linguagem deste programa", "C#", "Java com C"));
      return lista;
    }
  }
}
