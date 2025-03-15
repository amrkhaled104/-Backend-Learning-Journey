using System;
using System.Text;

namespace Generate_Random_number_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("[1] Generate random number\t\t[2] Generate random string");
                Console.Write("Please enter your option: ");

                if (!int.TryParse(Console.ReadLine(), out int selectOption) || (selectOption != 1 && selectOption != 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter either [1] or [2].");
                    Console.ResetColor();
                    return;
                }

                if (selectOption == 1) GenerateRandomNumber();
                else GenerateRandomString();
            }
        }

        static void GenerateRandomNumber()
        {
            Console.WriteLine("Enter Min & Max number: ");
            int min, max;
            if (!int.TryParse(Console.ReadLine(), out min) || !int.TryParse(Console.ReadLine(), out max))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: You must enter valid numbers.");
                Console.ResetColor();
                return;
            }

            if (min >= max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Min value must be less than Max value.");
                Console.ResetColor();
                return;
            }

            var rnd = new Random();
            Console.WriteLine($"Random Number = {rnd.Next(min, max)}");
        }

        static void GenerateRandomString()
        {
            int length;
            do
            {
                Console.Write("Enter length of string: ");
            } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);

            string bufferForCapital = "QWERTYUIOPLKJHGFDSAZXCVBNM";
            string bufferForSmall = "qwertyuioplkjhgfdsazxcvbnm";
            string bufferForNumbers = "0123456789";
            string bufferForSymbols = "!@#$%^&*()+_|?:~";

            Console.WriteLine("What would you like your string to include?");
            StringBuilder sb = new StringBuilder();

            Console.Write(" [1] Capital Letters? (yes/no): ");
            if ((Console.ReadLine()?.Trim().ToLower() ?? "") == "yes") sb.Append(bufferForCapital);

            Console.Write(" [2] Small Letters? (yes/no): ");
            if ((Console.ReadLine()?.Trim().ToLower() ?? "") == "yes") sb.Append(bufferForSmall);

            Console.Write(" [3] Numbers? (yes/no): ");
            if ((Console.ReadLine()?.Trim().ToLower() ?? "") == "yes") sb.Append(bufferForNumbers);

            Console.Write(" [4] Symbols? (yes/no): ");
            if ((Console.ReadLine()?.Trim().ToLower() ?? "") == "yes") sb.Append(bufferForSymbols);

            if (sb.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No character sets selected! Cannot generate a string.");
                Console.ResetColor();
                return;
            }

            var rnd = new Random();
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = sb[rnd.Next(sb.Length)];
            }

            Console.WriteLine($"\nGenerated Random String: {new string(result)}");
        }
    }
}
