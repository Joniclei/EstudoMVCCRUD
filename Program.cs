using System;

namespace PessoasMain
{
  class Program
  {
    static void Main(string[] args)
    {
      int op;

      do{
      Console.WriteLine("1-Crie um ser humaninho");
      Console.WriteLine("2-Liste");
      Console.WriteLine("3-TroKis");
      Console.WriteLine("4-Deletis ");
      Console.WriteLine("5-Sair");
      op = Convert.ToInt32(Console.ReadLine());
      switch(op){
        case 1:{
            PV.PessoasV.Criar();
          break;
        }
        case 2:{
            PV.PessoasV.Listar();

          break;
        }
        case 3:{
            PV.PessoasV.Trocar();
          break;
        }
        case 4:{
            PV.PessoasV.Deletar();
          break;
        }
      }

      }while(op!= 5);

    }
  }
}
