using System;
using System.Collections.Generic;
using System.Text;
using TextEditor;

namespace TextEditorTests
{
    class ChangeLogForTests : IChangeLog
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
                this._replaceWords.Add(@"\b" + "hösten" + @"\b", "vintern");
                return this._replaceWords;
            }
        }

        public List<string> ReverseWords
        {
            get
            {
                this._reverseWords = new List<string>();
                this._reverseWords.Add("nerammos");
                return this._reverseWords;
            }
        }

        public List<string> ToCapitalLetters
        {
            get
            {
                this._toCapitalLetters = new List<string>();
                this._toCapitalLetters.Add("louise");
                return this._toCapitalLetters;
            }
        }

        public List<String> ChangeLetterPosition
        {
            get
            {
                this._changeLetterPositions = new List<string>();
                this._changeLetterPositions.Add("iseLou");
                this._changeLetterPositions.Add("frontFore");
                return this._changeLetterPositions;
            }
        }
    }
}
