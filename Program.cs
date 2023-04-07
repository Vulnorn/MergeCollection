using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ObedinitVOdnyKollekciu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] characterStringFirst = new string[0];
            string[] characterStringSecond = new string[0];
            List<string> charactersFirst = new List<string>();
            List<string> charactersSecond = new List<string>();

            AddArray(characterStringFirst);
            AddInCollection(charactersFirst, characterStringFirst);
            AddArray(characterStringSecond);
            AddInCollection(charactersSecond, characterStringSecond);
            MergeCollections(charactersFirst, charactersSecond);
        }

        static string[] AddArray(string[] characterString)
        {
            string userInput;
            char whitespace = ' ';

            Console.WriteLine($"Введите строку с набором цифр через пробел");
            userInput = Console.ReadLine();
            characterString = userInput.Split(whitespace);

            return characterString;
        }

        static void AddInCollection(List<string> characters, string[] characterString)
        {
            for (int i = 0;i<characterString.Length; i++)
            {
                characters.Add(characterString[i]);
            }
        }

        static void MergeCollections(List<string> charactersFirst, List<string> charactersSecond)
        {
            var characters = charactersFirst.Union(charactersSecond);

            foreach (string symbol in characters)
                Console.Write($"{symbol} ");

            Console.ReadKey();
        }
    }
}