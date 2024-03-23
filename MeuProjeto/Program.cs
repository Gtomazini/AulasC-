namespace Mensagem
{
  class Produto
  {
    static void Main(string[] args)
    {
      Message msg1;
      msg1 = new Message();
      msg1.TextoMensagem = "Olá mundo by Gabriel";
      msg1.ShowMessage();

      Message msg2;
      msg2 = new Message();
      msg2.TextoMensagem = "No C#";
      msg2.ShowMessage();
      Console.ReadKey();
    }
  }
}

