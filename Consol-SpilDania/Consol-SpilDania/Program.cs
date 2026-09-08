using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Consol_SpilDania
{
    internal class Program
    {
        
        public ConsoleKeyInfo inputKey = Console.ReadKey(true);
        public bool isInBattle = false;
        public int IndextLoop = 0;
        public bool NewUser = true; 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!, enter your name:");
            String name = Console.ReadLine() ?? "Unknown";
            ConsoleKeyInfo startKey = Console.ReadKey(true);
            Program program = new Program();
            while (program.NewUser) 
            {
            switch (startKey.Key)
            { 
                case ConsoleKey.Enter:
                    Console.WriteLine($"Hello, {name}! a goblin is trying to attack you! !\n press A to start a battle");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ReadKey(); // gemmer sidste tast fra keyboardet.
                   
                    
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        program.InBattle(program.isInBattle, program.IndextLoop);
                        program.NewUser = false;
                    }
                    break;      
                }
            }
        }
        public void InBattle(bool isInBattle, int IndexLoop)
        {
            while (isInBattle)
            {
               switch ((IndexLoop = 1))
                {
                    case 1:



                        break;


                    default:

                        break;

                }

                
                
            }
        }
    }
}

