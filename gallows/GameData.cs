using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace gallows
{
    class GameData
    {
        public readonly string[] dataAr;
        private const string FILE_PATH = @"C:\Users\Дмитрий\Desktop\C#\taski\WordsStockRus.txt";

        public GameData()
        {
            dataAr = File.ReadAllText(FILE_PATH).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        public string GetWord()
        {
            Random rnd = new Random();
            return dataAr[rnd.Next(0, dataAr.Length - 1)];
        }
    }
}
