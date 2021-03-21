using System;

namespace MilhasParaKM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Digite uma medida em milhas: ");
            String medida = Console.ReadLine();
            Double milha = Convert.ToDouble(medida);
            Double quilometros = milha * 1.609;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{milha}mi é igual a {quilometros}km");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clique em uma tecla para finalizar este programa");
            Console.ReadKey();
            
            Console.Clear();
        }
    }
}
