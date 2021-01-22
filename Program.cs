using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5.1 Task 1 - How Old Are You?");
            Console.WriteLine("-------------------------");
            Task1HowOld();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5.1 Task 2 - Will it Freeze?");
            Console.WriteLine("----------------------------");
            Task2WillItFreeze();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5.1 Task 3 - The Magic Word");
            Console.WriteLine("----------------------------");
            Task3MagicWord();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }

        // 5.1 Task 1 - How Old Are You?
        public static void Task1HowOld()
        {
            string name;
            int age;
            Console.Write("Hey, what's your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ok, " + name + ", how old are you?  ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (age < 16)
            {
                Console.WriteLine("You can't drive.");
            }
            if (age < 18)
            {
                Console.WriteLine("You can't vote.");
            }
            if (age < 25)
            {
                Console.WriteLine("You can't rent a car.");
            }
            if (age >= 25)
            {
                Console.WriteLine("You can do anything that is legal.");
            }
        }

        // 5.1 Task 2 - Will it Freeze?
        public static void Task2WillItFreeze()
        {
            int temperature;
            Console.WriteLine("Please enter the freezing temperature of water: ");
            temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature == 0)
            {
                Console.WriteLine("Ahh yes, 0 degrees Celsius is correct.");
            }
            if (temperature == 32)
            {
                Console.WriteLine("Ahh yes, 32 degrees Fahrenheit is correct.");
            }
            if (temperature == 273)
            {
                Console.WriteLine("Ahh yes, 273.2 degrees Kelvin to be precise is correct.");
            }
        }

        // 5.1 Task 3 - The Magic Word
        public static void Task3MagicWord()
        {
            string magicWord;
            Console.WriteLine("Please say the magic word:  ");
            magicWord = Console.ReadLine();  
            // Converts magicWOrd to lowercase before comparison so it is not case snsitive
            if (magicWord.ToLower() == "please")
                Console.WriteLine("You're welcome.");
        }
    }
}
