using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nine
{
    public class GuessWordDictionaryEntry
    {
        private char[] m_wordArray = new char[9];

        public char[] WordArray { set { m_wordArray = value; } get { return m_wordArray; } }
        public int UsedTimes = 0, 
            GuessedTimes = 0;


        public GuessWordDictionaryEntry(string word)
        {
            if (word.Length != 9)
                throw new ApplicationException("Das Word <" + word + "> ist nicht exakt neun Zeichen lang");

            int i = 0;
            foreach (char c in word)
            {
                m_wordArray[i++] = c;
            }

        }


        public GuessWordDictionaryEntry(string word, int usedTimes, int guessedTimes) : this(word)
        {
            UsedTimes = usedTimes;
            GuessedTimes = guessedTimes;
        }
    }
}
