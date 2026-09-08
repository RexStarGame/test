using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Consol_SpilDania
{
    internal class Program
    {
        
        public static ConsoleKeyInfo inputKey = Console.ReadKey(true);
        public static bool normalAttack = false;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!, enter your name:");
            String name = Console.ReadLine() ?? "Unknown";
            ConsoleKeyInfo startKey = Console.ReadKey(true);
         
            switch (startKey.Key)
            { 
                case ConsoleKey.Enter:
                    Console.WriteLine($"Hello, {name}! a goblin is trying to attack you! !\n press A to start a battle");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ReadKey();
                    while(Console.ReadKey(false) != startKey)
                    {
                        //PlayerAttackChoice();
                    }
                    break;      
            }

        }
    }
}

