using System;


namespace PV
{
  class PessoasV
  {

    public static void Criar()
    {
      string nome;
      int idade;
      int cpf;
      Console.WriteLine("Nome:");
      nome = Console.ReadLine();
      Console.WriteLine("Idade");
      idade = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("cpf");
      cpf = Convert.ToInt32(Console.ReadLine());

      PC.PessoasC.Criar(nome, idade, cpf);
    }

    public static void Listar()
    {
      List<PM.PessoasM> x = PC.PessoasC.ListC();
      foreach (var y in x)
      {
        Console.WriteLine(y);
        ;
      }
    }

    public static void Trocar()
    {
      string nome;
      int idade;
      int cpf;
      int indice;

      Console.WriteLine("DIGITE O INDICE");
      indice = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Nome:");
      nome = Console.ReadLine();
      Console.WriteLine("Idade");
      idade = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("cpf");
      cpf = Convert.ToInt32(Console.ReadLine());

      PC.PessoasC.UP(indice,nome, idade, cpf);

    }
    public static void Deletar()
    {
      int indice;
      Console.WriteLine("DIGITE O INDICE");
      indice = Convert.ToInt32(Console.ReadLine());

      PC.PessoasC.Deletar(indice);
    }


  }
}
