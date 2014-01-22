using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nine
{
    public enum ProbType
    {
        notInDictionary = 0,
        invalidCharacter = 1,
        notWithCenterCharacter = 2,
        tooFewCharacters = 3,
        alreadyGuessed = 4,
        missingCharacter = 5
    }

    public class WordProblemException : ApplicationException
    {
        public ProbType ProblemType { set; get; }

        public WordProblemException(ProbType probt) : base()
        {
            ProblemType = probt;
        }
   
        public WordProblemException(ProbType probt, string message) : base(message)
        {
            ProblemType = probt;
        }
    }
}
