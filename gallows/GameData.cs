using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace gallows
{
    class GameData
    {
        public readonly int Tries;
        public readonly string[] DataAr;
        private const string FILE_PATH = @"C:\Users\Дмитрий\Desktop\C#\taski\WordsStockRus.txt";

        public GameData(int tries)
        {
            DataAr = File.ReadAllText(FILE_PATH).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Tries = tries;
        }
        public string GetWord()
        {
            Random rnd = new Random();
            return DataAr[rnd.Next(0, DataAr.Length - 1)];
        }
    }
}
