namespace HelloWorld;

class Atividade3
{
    public void Aritmetica()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double a =  Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double soma = a + b;
        Console.WriteLine($"Soma = {soma}");

        double subtracao = a - b;
        Console.WriteLine($"Subtração = {subtracao}");

        double multiplicacao = a * b;
        Console.WriteLine($"Multiplicação = {multiplicacao}");

        double divisao;
        if(b != 0)
        {
            Console.WriteLine($"Divisão = {divisao = a / b}");
        }
        else
        {
            Console.WriteLine("O segundo número tem que ser diferente de 0");
        }

        double media = (a + b) / 2;

        Console.WriteLine($"Média = {media}");
       
    }

  
}
