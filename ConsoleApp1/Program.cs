using System;
using ConsoleApp1.teste;

namespace ConsoleApp1;

class Program
{
    static void Main()
    {
       Carro meuCarro =  new();

       meuCarro.Ligar();
       meuCarro.Desligar();

       Biscoito meuBiscoito = new();

       meuBiscoito.Temperatura();
    }
}