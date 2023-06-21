using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace PM{
  class PessoasM{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Cpf { get; set; }

    public PessoasM(string nome, int idade, int cpf)
    {
      this.Nome = nome;
      this.Idade = idade;
      this.Cpf = cpf;

      PR.PessoasR.Criar(this);
    }
    public static List<PM.PessoasM> ListM(){
      return PR.PessoasR.Listar();
    }

    public static void UP(int indice,string nome,int idade,int cpf)
    {
      PessoasM pessoasM = PR.PessoasR.Listar()[indice];
      pessoasM.Nome = nome;
      pessoasM.Idade = idade;
      pessoasM.Cpf = cpf;
      PR.PessoasR.UP(indice,pessoasM);
    }

    public static void Deletar(int indice )
    {
      PR.PessoasR.Deletar(indice);
    }


    public override string ToString(){
      return Nome+ "   "+Idade+"CPF"+Cpf;
    }

  }
}
