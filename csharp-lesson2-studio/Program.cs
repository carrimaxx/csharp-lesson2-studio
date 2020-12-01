using System;
using System.Collections.Generic;

namespace csharp_lesson2_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characterDictionary = new Dictionary<char, int>();

            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

            foreach (char character in str)
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
