namespace HelloWorld;

class Atividade4
{
    public void contandoCaracteres()
    {
        Console.WriteLine("Digite uma ou mais palavras");
        string palavra = Console.ReadLine();

        int contador = 0;

        for(int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] != ' ')
            {
                contador++;
            }
        }

        Console.WriteLine($"O número de caracteres é = {contador}");
    }
}
