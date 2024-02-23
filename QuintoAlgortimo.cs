using System;

namespace algoritmo_23_02_2024
{
    class QuintoAlgoritmo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade?");
            
         
            int idade = int.Parse(Console.ReadLine());

       
            if (idade >= 18)
                Console.WriteLine("Você é maior de idade");
            else
                Console.WriteLine("Você é menor de idade");
        }
    }
}
