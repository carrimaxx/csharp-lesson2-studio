using System;
using System.Collections.Generic;

namespace csharp_lesson2_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characterDictionary = new Dictionary<char, int>();

            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            foreach (char character in str.ToLower())
            {
                if (!characterDictionary.ContainsKey(character))
                {
                    characterDictionary.Add(character, 1);
                }
                else
                {
                    characterDictionary[character]++;
                }                 
            }

            foreach (KeyValuePair<char,int> letter in characterDictionary)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
