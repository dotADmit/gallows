using System;
using System.Collections.Generic;

namespace gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData data = new GameData(6);
            int tries = data.Tries;
            bool isWinner = false;
            string word = data.GetWord();
            string triedLetters = "";
            List<string> userLetters = new List<string>();
            while (tries > 0)
            {
                if (!PrintWord(word, userLetters).Contains('*'))
                {
                    isWinner = true;
                    break;
                }

                Console.WriteLine(PrintWord(word, userLetters));
                Console.WriteLine($"Количество жизней: {tries}");
                Console.WriteLine(triedLetters);
                Console.Write("Введите букву: ");

                string temp = Console.ReadLine();
                userLetters.Add(temp);

                Console.Clear();

                if (word.Contains(temp))
                {
                    Console.WriteLine("Такая буква есть!");
                    continue;
                }
                if(tries > 1)
                    Console.WriteLine("Такой буквы нет!");
                tries--;
                triedLetters += $"-{temp.ToUpper()} ";
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
