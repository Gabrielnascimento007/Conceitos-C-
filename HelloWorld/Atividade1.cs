namespace HelloWorld;

class Atividade1
{
    public void LerNome()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }

    
}
