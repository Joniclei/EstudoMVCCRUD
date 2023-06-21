using System;
using PM;

namespace PR{
  class PessoasR{

    static List <PM.PessoasM> pessoinha = new List <PM.PessoasM>();

    public static void Criar(PM.PessoasM pessoathis){
      pessoinha.Add(pessoathis);
    }
    public static List<PM.PessoasM> Listar(){
      return pessoinha;
    }

    public static void UP(int indice,PM.PessoasM persona)
    {
      pessoinha [indice] = persona;
    }

    public static void Deletar(int indice)
    {
      pessoinha.RemoveAt(indice);
    }

    }
  }
