using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nine
{
    public class GuessWordDictionary
    {
        Random rnd = new Random();
        List<GuessWordDictionaryEntry> m_wordList;

        public int Count { get { return m_wordList.Count; } }
       

        /// <summary>
        /// Fetch a word from the wordlits an mark it as used
        /// </summary>
        /// <returns>a never beforde used word</returns>
        public char[] NewWord()
        {
            int wnum = 0;
            bool gotone = false;

            while (!gotone)
            {
                wnum = rnd.Next(Count);
                gotone = (m_wordList[wnum].UsedTimes == 0);
            }

            m_wordList[wnum].UsedTimes++;

            return m_wordList[wnum].WordArray;
        }

        internal void Load(string path)
        {
            StreamReader sr = new StreamReader(path);
            m_wordList = new List<GuessWordDictionaryEntry>();
            GuessWordDictionaryEntry gwditem;
            int used, guessed;
            string line;
            string[] toks;
            char[] seps = { ',' };

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Length > 0)
                {
                    toks = line.Split(seps);
                    if (!Int32.TryParse(toks[1], out used))
                        used = 0;
                    if (!Int32.TryParse(toks[2], out guessed))
                        guessed = 0;

                    gwditem = new GuessWordDictionaryEntry(toks[0].ToUpper(), used, guessed);
                    m_wordList.Add(gwditem);
                }
            }

            sr.Close();
        }
    }
}
