using System;

namespace ConsoleApp1;

public class Carro

{
    public void Ligar()
    {
        Console.WriteLine("Carro Ligado");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro Desligado");
    }

    private void Teste()
    {
        Console.WriteLine("Carro Desligado");
    }
    internal void Teste2()
    {
        Console.WriteLine("Carro Desligado");
    }
}
