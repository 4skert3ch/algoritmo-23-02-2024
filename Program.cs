namespace algoritmo_23_02_2024;
class Program
{
    static void Main()
    {
        Console.Write("Digite o ano: ");
        int ano = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(ano))
            Console.WriteLine($"{ano} é um ano bissexto.");
        else
            Console.WriteLine($"{ano} não é um ano bissexto.");
    }
}