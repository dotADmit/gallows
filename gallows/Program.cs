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
            string[] userLetters = new string[tries];
            for (int i = tries - 1; i >= 0; i--)
            {
                foreach (var item in word)
                {
                    bool isContains = false;
                    foreach (var item2 in userLetters)
                    {
                        if (item.ToString() == item2)
                        {
                            isContains = true;
                            break;
                        }
                    }

                    Console.Write(isContains ? item : '*');
                }
                Console.WriteLine();
                Console.WriteLine($"Количество жизней {i}");
                Console.Write(i == 0 ? "Введите слово: " : "Введите букву: ");
                userLetters[i] = Console.ReadLine();
                if (word.Contains(userLetters[i]))
                    Console.WriteLine("Такая буква есть!");
                else if(userLetters[i] == word) 
                {
                    isWinner = true;
                    break;
                }
                else
                    Console.WriteLine("Такой буквы нет!");
            }
            Console.WriteLine(isWinner ? "Вы угадали слово" : "Вы не угадали слово?") ;





            Console.ReadLine();

            Console.ReadLine();
            
        }
    }
}
