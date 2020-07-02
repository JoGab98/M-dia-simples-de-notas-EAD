using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.Title = "Média simples de notas AED";

            //Custom

            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;
            

            Console.WriteLine("Nome da pessoa:");
            Console.ForegroundColor = ConsoleColor.White;
            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Media de notas na AED de " + userName);
            Console.ForegroundColor = ConsoleColor.Gray;

            double num01;
            double num02;
            double num03;
            
            Console.Write("Nota 1: ");
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Nota 2: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Nota 3: ");
            num03 = Convert.ToDouble( Console.ReadLine() );

            double result = (num01 + num02 + num03) / 3;

            Console.WriteLine("A média das três notas é:" + result );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nome da pessoa:");
            Console.ForegroundColor = ConsoleColor.White;
            string userName1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Media de notas na AED de " + userName1);
            Console.ForegroundColor = ConsoleColor.Gray;

            double num04;
            double num05;
            double num06;
            
            Console.Write("Nota 1: ");
            num04 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Nota 2: ");
            num05 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Nota 3: ");
            num06 = Convert.ToDouble( Console.ReadLine() );

            double result1 = (num04 + num05 + num06) / 3;

            Console.WriteLine("A média das três notas é:" + result1 );
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Obrigado por usar a aplicação. Atualizações em breve!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PARA FECHAR O PROGRAMA PRESSIONE QUALQUER TECLA!");

            Console.ReadKey();
        }
    }
}
