using System.Text.RegularExpressions;

namespace HelloWorld;

class Atividade5
{
    public void validarPlacas()
    {
        Console.WriteLine("Digite a placa do veículo: Ex(ABC1234)");
        string placa = Console.ReadLine().ToUpper();
        
        if(placa.Length == 7 && Regex.IsMatch(placa,@"^[A-Z]{3}\d{4}$"))
        {
            Console.WriteLine($"Placa cálida: {placa}");
        }
        else
        {
            Console.WriteLine("A placa tem que ter 7 caracteres alfanúmericos, e 3 letras seguidas de 4 números. Ex: ABC1234");
        }

        
    }
}
