using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DictReader
{
    public class WordDictionary
    {
        List<string> m_words;
        public List<string> Words { get{return m_words;} }

        public WordDictionary(string filename) : this(filename, true, false)
        {
        }

        public WordDictionary(string filename, bool caseSensitive, bool crosswordstyle)
        {
            InitFormFile(filename, caseSensitive, crosswordstyle);
        }

        protected WordDictionary()
        {
            m_words = new List<string>();
        }

        public WordDictionary GetByLength(int len)
        {
            WordDictionary answ = new WordDictionary();

            foreach (string word in Words)
            {
                if (word.Length == len)
                    answ.Words.Add(word);
            }

            return answ;
        }

        public WordDictionary GetByMaxLength(int len)
        {
            WordDictionary answ = new WordDictionary();

            foreach (string word in Words)
            {
                if (word.Length <= len)
                    answ.Words.Add(word);
            }

            return answ;
        }

        private void InitFormFile(string path, bool caseSensitive, bool crosswordstyle)
        {
            StreamReader sr = new StreamReader(path);
            string rawins, currs;
            m_words = new List<string>(100000);
            int numprevchars;

            while (!sr.EndOfStream)
            {
                rawins = sr.ReadLine();
                currs = "";
                numprevchars = Decode(rawins[0]);

                if (numprevchars > 0)
                {
                    currs = Words[Words.Count - 1].Substring(0, numprevchars);
                }

                currs += rawins.Substring(1);

                if(caseSensitive)
                    Words.Add(currs);
                else
                    Words.Add(currs.ToUpper());
            }

            sr.Close();

            //Now translate the umlaut characters

            for (int i=0; i<Words.Count; i++)
            {
                Words[i] = Translate(Words[i], crosswordstyle);
            }
        }

        private string Translate(string word, bool crosswordstyle)
        {
            string answ = "";
            char prevchar = ' ', newprevchar;
            bool first = true;

            foreach (char c in word)
            {
                if (first)
                {
                    answ += c;
                    first = false;
                }
                else
                {
                    if (c == '\"')
                    {
                        if (crosswordstyle)
                        {
                            answ += "e";
                        }
                        else
                        {
                            switch (prevchar)
                            {
                                case 'A': newprevchar = 'Ä';
                                    break;
                                case 'U': newprevchar = 'Ü';
                                    break;
                                case 'O': newprevchar = 'Ö';
                                    break;
                                case 'a': newprevchar = 'ä';
                                    break;
                                case 'u': newprevchar = 'ü';
                                    break;
                                case 'o': newprevchar = 'ö';
                                    break;
                                default:
                                    newprevchar = '?';
                                    break;
                            }

                            answ = answ.Substring(0, answ.Length - 1) + newprevchar;
                        }
                    }
                    else if ((c == 'S') && (prevchar == 's'))
                    {
                        if (crosswordstyle)
                            answ += 's';
                        else
                            answ = answ.Substring(0, answ.Length - 1) + 'ß';
                    }
                    else
                        answ += c;

                }

                prevchar = c;
            }

            return answ;
        }

        /// <summary>
        /// Decodes a char to a number. 0 is 0, 1 is 1, ... A is 10, Z is (calculate that yourself)
        /// </summary>
        /// <param name="numcode">a character containing the code</param>
        /// <returns>An integer number representing the code</returns>
        private int Decode(char numcode)
        {
            int answ;
            switch (numcode)
            {
                case '0': answ = 0;
                    break;
                case '1': answ = 1;
                    break;
                case '2': answ = 2;
                    break;
                case '3': answ = 3;
                    break;
                case '4': answ = 4;
                    break;
                case '5': answ = 5;
                    break;
                case '6': answ = 6;
                    break;
                case '7': answ = 7;
                    break;
                case '8': answ = 8;
                    break;
                case '9': answ = 9;
                    break;
                case 'A': answ = 10;
                    break;
                case 'B': answ = 11;
                    break;
                case 'C': answ = 12;
                    break;
                case 'D': answ = 13;
                    break;
                case 'E': answ = 14;
                    break;
                case 'F': answ = 15;
                    break;
                case 'G': answ = 16;
                    break;
                case 'H': answ = 17;
                    break;
                case 'I': answ = 18;
                    break;
                case 'J': answ = 19;
                    break;
                case 'K': answ = 20;
                    break;
                case 'L': answ = 21;
                    break;
                case 'M': answ = 22;
                    break;
                case 'N': answ = 23;
                    break;
                case 'O': answ = 24;
                    break;
                case 'P': answ = 25;
                    break;
                case 'Q': answ = 26;
                    break;
                case 'R': answ = 27;
                    break;
                case 'S': answ = 28;
                    break;
                case 'T': answ = 29;
                    break;
                case 'U': answ = 30;
                    break;
                case 'V': answ = 31;
                    break;
                case 'W': answ = 32;
                    break;
                case 'X': answ = 33;
                    break;
                case 'Y': answ = 34;
                    break;
                case 'Z': answ = 35;
                    break;
                default:
                    throw new ApplicationException("Unbekannter Zahlencode <" + numcode + ">");
            }

            return answ;
        }

        /// <summary>
        /// Lookup a word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool LookUp(string word)
        {
            return m_words.Contains(word);
        }
    }
}
