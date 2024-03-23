namespace AnimalControl
{
  class Animal
  {
    private String nome;
    public String Nome
    {
      get { return nome; }
      set { nome = value.ToUpper(); }
    }

    private String tipo;
    public String Tipo
    { // valores pré definidos pelo proprietario
      get { return tipo; }
      set
      {
        if (value == "Cachorro" || value == "Gato" || value == "Peixe")
        {
          tipo = value;
        }
        else
        {
          tipo = "Peixe";
        }
      }
    }



  }
}
