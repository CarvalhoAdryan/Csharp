using System;
using System.Dynamic;
using System.Reflection.PortableExecutable;

namespace ConsoleApp1;

public class Carro

{
    public string Model {get; set;}
    public DateOnly LancadoEm {get; set;}
    public Cor Cor {get; set;}

    public Carro(string model)
    {
        Model = model;
    }
    public void NomeModelo() => Console.WriteLine(Model);
    // public void Ligar()
    // {
    //     Console.WriteLine("Carro Ligado");
    // }

    // public void Desligar()
    // {
    //     Console.WriteLine("Carro Desligado");
    // }

    // private void Teste()
    // {
    //     Console.WriteLine("Carro Desligado");
    // }
    // internal void Teste2()
    // {
    //     Console.WriteLine("Carro Desligado");
    // }
}


