using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TextEditor
{
    class ChangeLog : IChangeLog
    {
        public Dictionary<string, string> _replaceWords;
        public List<string> _reverseWords;
        public List<string> _toCapitalLetters;
        public List<string> _changeLetterPositions;

        public Dictionary<string, string> ReplaceWords
        {
            get
            {
                this._replaceWords = new Dictionary<string, string>();
                this._replaceWords.Add(@"\b" + "företaget" +  @"\b", "Forefront");
                this._replaceWords.Add(@"\b" + "förpestas" + @"\b", "förgyllas");
                this._replaceWords.Add(@"\b" + "inget" + @"\b", "allt");
                this._replaceWords.Add(@"\b" + "äppelkaka" + @"\b", "motstånd");
                this._replaceWords.Add(@"(?<=\bs[\S]*\s)av", "från");
                this._replaceWords.Add(@"(?<=code is \b)" + "king", "Queen");
                this._replaceWords.Add(@"regel rätta", "regelrätta");
                this._replaceWords.Add(@"kod ninjor", "kodninjor");
                return this._replaceWords;
            }
        }

        public List<string> ReverseWords
        {
            get
            {
                this._reverseWords = new List<string>();
                this._reverseWords.Add("räh");
                this._reverseWords.Add("remmok");
                return this._reverseWords;
            }
        }

        public List<string> ToCapitalLetters
        {
            get
            {
                this._toCapitalLetters = new List<string>();
                this._toCapitalLetters.Add("frontiers");
                this._toCapitalLetters.Add("om");
                this._toCapitalLetters.Add("king");
                return this._toCapitalLetters;
            }
        }

        public List<String> ChangeLetterPosition
        {
            get
            {
                this._changeLetterPositions = new List<string>();
                this._changeLetterPositions.Add("nnasta");
                this._changeLetterPositions.Add("eernatrain");
                this._changeLetterPositions.Add("ortgj");
                return this._changeLetterPositions;
            }
        }
    }
}
