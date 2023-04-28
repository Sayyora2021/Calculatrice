using System;
using System.Collections.Generic;

namespace Calculatrice
{
    class Program
    {
        static Dictionary<string, Func<int, int, int>> operations = new()
        {
            { "+", (a, b) => a + b },
            { "-", (a, b) => a - b },
            { "*", (a, b) => a * b },
            { "/", (a, b) => a / b }
        };

        static void Main(string[] args)
        {
            do
            {
                if (SaisirNombre("Entrez un premier nombre", out int a) &&
                    SaisirNombre("Entrez un deuxième nombre", out int b))
                {
                    Console.WriteLine("Entrez un symbole d'opération");
                    string operateur = Console.ReadLine();
                    if (operations.TryGetValue(operateur, out Func<int, int, int> operation))
                    {
                        Calculer(operation, operateur, a, b);
                    }
                    else
                    {
                        Console.WriteLine("Opérateur invalide.");
                    }
                }
                Console.WriteLine("Tapez ESC pour quitter ou une autre touche pour continuer.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void Calculer(Func<int, int, int> operation, string operateur, int a, int b)
        {
            Console.WriteLine($"{a} {operateur} {b} = {operation(a, b)}");
        }

        private static bool SaisirNombre(string message, out int valeur)
        {
            Console.WriteLine(message);
            return int.TryParse(Console.ReadLine(), out valeur);
        }
    }
}
//static Dictionary<string, Func<int, int, int>> operations = new()
//        {
//            { "+", (a, b) => a + b },
//            { "-", (a, b) => a - b },
//            { "*", (a, b) => a * b },
//            { "/", (a, b) => a / b }
//        };

//static void Main(string[] args)
//{
//    do
//    {
//        if (SaisirNombre("Entrez un premier nombre", out int a) &&
//            SaisirNombre("Entrez un deuxième nombre", out int b))
//        {
//            Console.WriteLine("Entrez un symbole d'opération");
//            string operateur = Console.ReadLine();
//            if (operations.TryGetValue(operateur, out Func<int, int, int> operation))
//            {
//                Calculer(operation, operateur, a, b);
//            }
//            else
//            {
//                Console.WriteLine("Opérateur invalide.");
//            }
//        }
//        Console.WriteLine("Tapez ESC pour quitter ou une autre touche pour continuer.");
//    } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
//}

//private static void Calculer(Func<int, int, int> operation, string operateur, int a, int b)
//{
//    Console.WriteLine($"{a} {operateur} {b} = {operation(a, b)}");
//}

//private static bool SaisirNombre(string message, out int valeur)
//{
//    Console.WriteLine(message);
//    return int.TryParse(Console.ReadLine(), out valeur);
//}