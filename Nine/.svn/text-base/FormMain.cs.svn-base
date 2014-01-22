using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DictReader;

namespace Nine
{
    public partial class FormMain : Form
    {
        const int MAXSHUFFLE = 40;
        const int MINIMUMCHARACTERS = 4;

        string Solution 
        {

            get
            {
                string answ = "";
                foreach (char c in currentWord)
                {
                    answ += c;
                }

                return answ;
            } 
        }

        GuessWordDictionary wd = new GuessWordDictionary();
        char[] currentWord, currentWordScrambled;
        bool[] usedInInput = new bool[9];
        List<string> langDict;
        int pts = 0;
        bool cheated = false;
        bool dirtyDict = false;

        Random rnd = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            langDict = ReadDictionary("dictionary.txt");

            wd.Load("wordstoguess.txt");
            SetNewWord();
            SetPoints();
        }

        private void SetPoints()
        {
            if (!cheated)
                SetPoints(pts.ToString());
                
        }

        private void SetPoints(string disp)
        {
            ptsL.Text = disp;
        }


        /// <summary>
        /// Read the dictionary file into a list
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <returns>the list</returns>
        private List<string> ReadDictionary(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> answ = new List<string>();
            string currl;

            while (!sr.EndOfStream)
            {
                currl = sr.ReadLine();
                if (currl.Length > 0)
                    answ.Add(currl.ToUpper());
            }

            sr.Close();

            return answ;
        }

        private void newGameBU_Click(object sender, EventArgs e)
        {
            SetNewWord();
            SetPoints();
        }

        private void SetNewWord()
        {
            //pick a word
            currentWord = wd.NewWord();
            
            //scramble the word
            currentWordScrambled = ScrambleWord(currentWord);

            SetWord(currentWordScrambled);
        }


        /// <summary>
        /// Do everything  to make that word visible
        /// </summary>
        private void SetWord(char[] word)
        {
            //insert it into the labels
            l0.Text = currentWordScrambled[0].ToString();
            l1.Text = currentWordScrambled[1].ToString();
            l2.Text = currentWordScrambled[2].ToString();
            l3.Text = currentWordScrambled[3].ToString();
            l4.Text = currentWordScrambled[4].ToString();
            l5.Text = currentWordScrambled[5].ToString();
            l6.Text = currentWordScrambled[6].ToString();
            l7.Text = currentWordScrambled[7].ToString();
            l8.Text = currentWordScrambled[8].ToString();

            for (int i = 0; i < 9; i++)
                usedInInput[i] = false;

            pts = 0;
            cheated = false;

            guessedWordsLB.Items.Clear();
            
            if (currentWord == null)
                solveBU.Enabled = false;
            else
                solveBU.Enabled = true;
        }

        private char[] ScrambleWord(char[] cw)
        {
            char[] answ = cw.Clone() as char[];
            char merker;
            int shuffleFrom, shuffleTo;

            for (int i = 0; i < MAXSHUFFLE; i++)
            {
                shuffleFrom = rnd.Next(9);
                shuffleTo = rnd.Next(9);

                if (shuffleTo != shuffleFrom)
                {
                    merker = answ[shuffleTo];
                    answ[shuffleTo] = answ[shuffleFrom];
                    answ[shuffleFrom] = merker;
                }
            }

            return answ;
        }

        private void exitGameBU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void solveBU_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Das Lösungswort ist: \"" + Solution + "\"");
            cheated = true;

            SetPoints(":-(");
        }


        /// <summary>
        /// The user changed something in the guessBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guessTB_TextChanged(object sender, EventArgs e)
        {

        }

     

        

        private void guessTB_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void guessTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                //the user chose to give the word a try
                try
                {
                    ProcessWord((sender as TextBox).Text);

                    guessTB.Text = "";
                }
                catch (WordProblemException wepx)
                {
                    if (wepx.ProblemType == ProbType.notInDictionary)
                    {
                        DialogResult res = MessageBox.Show(this, wepx.Message + " Soll das Wort in das Wörterbuch aufgenommen werden?", "Anfrage", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            AddToDictionary(guessTB.Text);
                            // and try again

                            try
                            {
                                ProcessWord((sender as TextBox).Text);

                                guessTB.Text = "";
                            }
                            catch (WordProblemException wexp2)
                            {
                                MessageBox.Show(wexp2.Message);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show(wepx.Message);
                    }
                }
            }
            else if (
                Char.IsPunctuation(e.KeyChar)
                || Char.IsSeparator(e.KeyChar)
                || Char.IsSymbol(e.KeyChar)
                || Char.IsDigit(e.KeyChar)
                ||  (Char.IsLetter(e.KeyChar) && !currentWordScrambled.Contains(Char.ToUpper(e.KeyChar))                    )
                )
            {
                e.Handled = true;
            }
        }

        private void AddToDictionary(string newWord)
        {
            langDict.Add(newWord);
            dirtyDict = true;
        }

        /// <summary>
        /// check wether a word is valid, calculate it's points and the add everything 
        /// to the list of guessed words.
        /// 
        /// </summary>
        /// <param name="guessedword"></param>
        private void ProcessWord(string guessedword)
        {
 
            //check if the word has at least the minimum numbe rof characters
            if (guessedword.Length < MINIMUMCHARACTERS)
                throw new WordProblemException(ProbType.tooFewCharacters, "Das Wort muss mindestens " + MINIMUMCHARACTERS + " Zeichen aufweisen.");

            //check if the word contains the center character
            if (!guessedword.Contains(l4.Text))
                throw new WordProblemException(ProbType.notWithCenterCharacter, "Das Word enthält nicht den zentralen Buchstaben <" + l4.Text + ">");


            //check if the word is a valid word by comparing it with the dictionary
            if (!WordIsValid(guessedword))
                throw new WordProblemException(ProbType.notInDictionary, "Das Wort <" + guessedword + "> ist im deutschen Wörterbuch nicht auffindbar.");

            if (!WordIsInLetters(guessedword, currentWordScrambled))
                throw new WordProblemException(ProbType.missingCharacter, "Einer der Buchstaben des Ratewortes ist nicht oder in zu geringer Anzahl vorhanden");

            int mypts = CalbulatePoints(guessedword);
            string listentry = String.Format("{0,-9} : {1,2:d}", guessedword, mypts);

            if(guessedWordsLB.Items.Contains(listentry))
                throw new WordProblemException(ProbType.alreadyGuessed, "Das Wort <" + guessedword + "> wurde bereits erraten.");

            //It's a valid word, so add it to the word list and remove it from the entry box
            guessedWordsLB.Items.Add(listentry);
            guessTB.Text = "";

            //add the pints for the word and show them on the GUI
            pts += mypts;
            SetPoints();
        }

        private bool WordIsInLetters(string guessedword, char[] cw)
        {
            List<char> checkoutList = cw.ToList<char>();
            bool answ = true;
            int pos;
            
            int i=0;
            while(answ && (i<guessedword.Length))
            {
                pos = checkoutList.IndexOf(guessedword[i]);
                if (pos >= 0)
                    checkoutList[pos] = '&';
                else
                    answ = false;

                i++;
            }

            return answ;
        }


        /// <summary>
        /// Calculate the points for a word.
        /// </summary>
        /// <param name="guessedword"></param>
        /// <returns></returns>
        private int CalbulatePoints(string guessedword)
        {
            int ptsum = guessedword.Length;

            if (ptsum == 9)
                ptsum = 20;

            return ptsum;

        }

        /// <summary>
        /// Check a word by looking it up in the dictionary.
        /// </summary>
        /// <param name="guessedword"></param>
        /// <returns></returns>
        private bool WordIsValid(string word)
        {
            return langDict.Contains(word);
        }

        private void guessTB_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dirtyDict)
                WriteDictionary(langDict);
        }


        /// <summary>
        /// Write the dictionary to a file one word for each line line
        /// </summary>
        /// <param name="dict">a dictionary</param>
        private void WriteDictionary(List<string> dict)
        {
            //sort it
            dict.Sort();

            //and write it to a file
            StreamWriter sr = new StreamWriter("dictionary.txt");
            foreach (string word in dict)
                sr.WriteLine(word);

            sr.Close();
        }

        private void helpBU_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("rulesandhelp.txt");
            string msg = sr.ReadToEnd();
            
            sr.Close();

            FormHelp fh = new FormHelp();
            fh.Show(this, msg);
        }

        /// <summary>
        /// The user wants to give a new word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewWord_Click(object sender, EventArgs e)
        {
            FormEnterWord few = new FormEnterWord();

            DialogResult res = few.ShowDialog(this);

            if (res == DialogResult.OK)
            {
                currentWordScrambled = few.TheWord;
                currentWord = null;
                SetWord(currentWordScrambled);
                SetPoints();
            }


        }
    }
}
