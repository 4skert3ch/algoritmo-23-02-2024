using System;

namespace algoritmo_23_02_2024
{
    class QuartoAlgoritmo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatua");
            
         
            int temperatura = int.Parse(Console.ReadLine());

       
            if (temperatura > 35)
                Console.WriteLine("use protetor solar");
            else
                Console.WriteLine("Curta bem a temperatura");
        }
    }
}
