using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många sporter vill du skriva in?");
            int Sportantal = int.Parse(Console.ReadLine());
            string[] sport = new string[Sportantal];
            int x = 0;
            
            for (int i = 0; i < sport.Length; i++)
            {
                Console.WriteLine("Skriv in sporterna med deras namn");
                sport[i] = Console.ReadLine();
            }
            Console.WriteLine("Det här är sporterna du skrev in");
            for (int i = 0; i < sport.Length; i++)
            {
                Console.Write(" "+sport[i]);
            }         
        }
    }
}