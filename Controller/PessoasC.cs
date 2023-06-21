using System;


namespace PC
{
  class PessoasC
  {

    public static void Criar(string nome, int idade, int cpf)
    {
      new PM.PessoasM(nome, idade, cpf);
    }
    public static List<PM.PessoasM> ListC(){
      return PM.PessoasM.ListM();
    }

    public static void UP(int indice,string nome,int idade,int cpf)
    {
      PM.PessoasM.UP(indice, nome, idade, cpf);
    }

    }

  }
