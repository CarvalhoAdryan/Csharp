using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

class Program
{
    enum Dificuldade{
        Baixo = 0,
        Medio = 1,
        Alto = 2
    };

    static void Main()
    {
        int numero = 0;
        double saldo = 108.8;
        bool ativo = true;
        string autor = numero == 7 ? "Adryan" : "Lindo"; // if ternario ? se : se não
        List<int> inteiros = [1,2,3];
        Cor Cor = Cor.preto;

        foreach (var num in inteiros)
        {
            Console.WriteLine(num);
        }


        // for (int i = 0; i <= 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

    //     string nome = numero switch
    //     {
    //         7 => "Adryan",
    //         8 => "Lindo",
    //         9 => "mimimi",
    //         _ => "Desconhecido"
    //     };

    //     Console.WriteLine(nome);

    //    switch (Cor)
    //    {
    //         case Cor.azul:
    //             {
    //                 Console.WriteLine("Cor azul");
    //             }
    //             break;
    //         case Cor.preto:
    //             {
    //                 Console.WriteLine("Cor preto");
    //             }
    //             break;
    //         case Cor.vermelho:
    //             {
    //                 Console.WriteLine("Cor vermeho");
    //             }
    //             break;
    //    }
        


        

        // var meuCarro = new Carro("fiat")
        // {
        //   Cor = Cor.preto,
        //   LancadoEm = new DateOnly(2012,05,28)  
        // };


        // Console.WriteLine(meuCarro.Cor);
        // Console.WriteLine(meuCarro.LancadoEm);
        // meuCarro.NomeModelo();

        // Console.WriteLine("Oi");
    //    meuCarro.Ligar();
    //    meuCarro.Desligar();

    //    Biscoito meuBiscoito = new();

    //    meuBiscoito.Temperatura();

    //    DateOnly dia = new(2023,12,1); 

    //    string diaEmTexto = dia.ToString("D",new CultureInfo("pt-BR"));
    //    DateTime hoje = DateTime.UtcNow; 
    //    Console.WriteLine(diaEmTexto);
    //    Console.WriteLine(hoje);

    //    Dificuldade nivel = Dificuldade.Baixo;

    //    int nivelint = (int)Dificuldade.Alto;

    //    Console.WriteLine(nivel);
    //    Console.WriteLine(nivelint);

        // string nome = "Adryan";
        // Console.WriteLine(nome);

        // string  lastname = "lindo";
        // Console.WriteLine(lastname);

        // int? idade = null;

        // List<string> texto = ["Hello"];

        // texto.Add("Mundo");

        // string concat = string.Join(" ", texto ); //lista tudo, junta toda a lista 
        // Console.WriteLine(concat);
        // Dictionary<int, string> dicionario = [];
        // dicionario.Add(5, "Adryan");

        // Console.WriteLine(dicionario[5]);

        // Console.WriteLine(Math.Soma(1,2));

   } 

}