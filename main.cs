using System;

class Program
{
    class Pessoa{
      public string Nome;
      public int Idade;
    }

    class Amiga : Pessoa{
     public int Level;
     public int TempoQueConhece;
    }

    class Familia : Amiga{
      public string Grau;
    }
  
    public static void Main(string[] args)
    {

        //Familia familia = new Familia();
        //familia.

      
        //CRIAR 4 VARIAVEIS COM AS IDADES DA FAMILIA 
        //ESCREVA A SOMA DAS NOSSAS IDADES NO ECRA
        int ageLuna = 8;
        int ageLis = 12;
        int agePai = 42;
        int ageDaniela = 42;
     
    //Helo everyone
      
        Console.WriteLine(ageLuna);
        Console.WriteLine(ageLis);
        Console.WriteLine(agePai);
        Console.WriteLine(ageDaniela);
        Console.WriteLine(ageLuna + ageLis + agePai + ageDaniela);
    }
}


