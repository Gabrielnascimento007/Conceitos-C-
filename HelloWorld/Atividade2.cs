﻿namespace HelloWorld;

class Atividade2
{
    public void nomeSobrenome()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine(nome + " " + sobrenome);
    }
}
