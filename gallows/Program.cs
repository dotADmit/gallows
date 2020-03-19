using System;
using System.Collections.Generic;

namespace gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData data = new GameData();
            int tries = 6;
            bool isWinner = false;
            string word = data.GetWord();
            List<string> userLetters = new List<string>();
            while (tries > 0)
            {
                if (!PrintWord(word, userLetters).Contains('*'))
                {
                    isWinner = true;
                    break;
                }
                Console.WriteLine(PrintWord(word, userLetters));

                Console.WriteLine();
                Console.WriteLine($"Количество жизней: {tries}");
                foreach (var item in userLetters)
                {
                    if (!word.Contains(item))
                    {
                        Console.Write($"-{item.ToUpper()} ");
                    }
                }
                Console.WriteLine();
                Console.Write(tries == 1 ? "Введите слово: " : "Введите букву: ");
                string temp = Console.ReadLine();
                userLetters.Add(temp);
                if (temp == word)
                {
                    isWinner = true;
                    break;
                }
                Console.Clear();

                if (word.Contains(temp))
                {
                    Console.WriteLine("Такая буква есть!");
                    continue;
                }
                if(tries > 1)
                    Console.WriteLine("Такой буквы нет!");
                tries--;
            }

            Console.WriteLine(isWinner ? "Поздравляем!!! Вы угадали слово!!!" : "Вы не угадали слово =(") ;
            Console.WriteLine("Загаданное слово: " + word + ".");





            Console.ReadLine();

            Console.ReadLine();
            
        }
        static string PrintWord(string word, List<string> letters)
        {
            string temp = "Загаданное слово: ~";
            foreach (var item in word)
            {
                bool isContains = false;
                foreach (var item2 in letters)
                {
                    if (item.ToString() == item2)
                    {
                        isContains = true;
                        break;
                    }
                }
                temp += isContains ? $"|{item}" : "|*";
            }
            return $"{temp}|~";
        }
    }
}
