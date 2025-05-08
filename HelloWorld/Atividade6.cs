using System.Globalization;

namespace HelloWorld;

class Atividade6
{
    public void tiposData()
    {
        var date = DateTime.Now;
        var br = new CultureInfo("pt-BR");

        Console.WriteLine($"Formato completo: {date.ToString("dddd, dd/MM/yyyy HH:mm:ss", br)}");
        Console.WriteLine($"Formato de número: {date.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Formato de horas: {date.ToString("HH:mm:ss")}");
        Console.WriteLine($"Formato mês por extenso: {date.ToString("dd 'de' MMMM 'de' yyyy", br)}");
    }
}
