using System;
using System.Collections.Generic;

namespace gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData data = new GameData();
            string word = data.GetWord();
            string[] userLetters = new string[6];
            foreach (var item in word)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            Console.Write("Введите букву: ");
            userLetters[0] = Console.ReadLine();
            if (word.Contains(userLetters[0]))
                Console.WriteLine("Такая буква есть!");
            else
                Console.WriteLine("Такой буквы нет!");





            Console.ReadLine();
            
        }
    }
}
