using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DictReader;

namespace ExtraktNiners
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDictionary wdict = new WordDictionary("german.words", true, true);

            WordDictionary niners = wdict.GetByMaxLength(9);

            StreamWriter sr9 = new StreamWriter("wordstoguess.txt");
            StreamWriter sr = new StreamWriter("dictionary.txt");
            foreach (string word in niners.Words)
            {
                if(word.Length==9)
                    sr9.WriteLine(word + "," + "0,0");

                sr.WriteLine(word);
            }

            sr.Close();
            sr9.Close();

        }
    }
}
