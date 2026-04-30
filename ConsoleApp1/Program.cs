using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using ConsoleApp1.teste;

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
       Carro meuCarro =  new();

       meuCarro.Ligar();
       meuCarro.Desligar();

       Biscoito meuBiscoito = new();

       meuBiscoito.Temperatura();

       DateOnly dia = new(2023,12,1); 

       string diaEmTexto = dia.ToString("D",new CultureInfo("pt-BR"));
       DateTime hoje = DateTime.UtcNow; 
       Console.WriteLine(diaEmTexto);
       Console.WriteLine(hoje);

       Dificuldade nivel = Dificuldade.Baixo;

       int nivelint = (int)Dificuldade.Alto;

       Console.WriteLine(nivel);
       Console.WriteLine(nivelint);

    }
}