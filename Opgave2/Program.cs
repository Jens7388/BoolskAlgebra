using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Vælg en af følgende muligheder");
                Console.WriteLine("1. Skriv et heltal i intervallet 0-10");
                Console.WriteLine("2. Skriv et kommatal i intervallet 0-1");
                Console.WriteLine("3. Skriv et heltal i intervallet -10-10, ekslusiv 0");
                Console.WriteLine("4. Skriv en vokal");
                Console.WriteLine("5. Skriv en konsonant");
                Console.WriteLine("6. Skriv et enkeltcifret tal");
                Console.WriteLine("7. Skriv 'exit' eller 'quit'");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.Write("\nSkriv et heltal i intervallet 0-10:");
                        string intervalInput = Console.ReadLine();
                        int.TryParse(intervalInput, out int interval);
                        if(interval >= 0 && interval <= 10)
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    case "2":
                        Console.Write("\nSkriv et kommatal i intervallet 0-1:");
                        string commaIntervalInput = Console.ReadLine();
                        double.TryParse(commaIntervalInput, out double commaInterval);
                        if(commaInterval > 0 && commaInterval < 1)
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    case "3":
                        Console.Write("\nSkriv et heltal i intervallet -10-10, ekslusiv 0:");
                        string secondIntervalInput = Console.ReadLine();
                        int.TryParse(secondIntervalInput, out int secondInterval);
                        if(secondInterval >= -10 && secondInterval != 0 && secondInterval <= 10)
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    case "4":
                        Console.Write("\nSkriv en vokal:");
                        string vowelInput = Console.ReadLine();
                        char.TryParse(vowelInput, out char vowel);
                        if(vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u' || vowel == 'æ' || vowel == 'ø' || vowel == 'å')
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    case "5":
                        Console.Write("\nSkriv en konsonant:");
                        string consonantInput = Console.ReadLine();
                        char.TryParse(consonantInput, out char consonant);
                        if(consonant == 'b' || consonant == 'c' || consonant == 'd' || consonant == 'f' || consonant == 'g' ||
                           consonant == 'h' || consonant == 'j' || consonant == 'k' || consonant == 'l' || consonant == 'm' ||
                           consonant == 'n' || consonant == 'p' || consonant == 'q' || consonant == 'r' || consonant == 's' ||
                           consonant == 't' || consonant == 'v' || consonant == 'w' || consonant == 'x' || consonant == 'z')
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    case "6":
                        Console.Write("\nSkriv et enkeltcifret tal:");
                        string numberInput = Console.ReadLine();
                        char.TryParse(numberInput, out char number);
                        if(number == '1' || number == '2' || number == '3' || number == '4' || number == '5' ||
                           number == '6' || number == '7' || number == '8' || number == '9' || number == '0')
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    case "7":
                        Console.Write("\nSkriv 'exit' eller 'quit':");
                        string exitQuit = Console.ReadLine();
                        if(exitQuit == "exit" || exitQuit == "quit")
                        {
                            Console.WriteLine("Opgaven er løst!");
                        }
                        else
                        {
                            Console.WriteLine("Prøv igen");
                        }
                        break;
                    default:
                        Console.WriteLine("Prøv igen");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
