using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    public interface IChangeLog
    {
        Dictionary<string, string> ReplaceWords
        {
            get;
        }
        List<string> ReverseWords
        {
            get;
        }
        List<string> ToCapitalLetters
        {
            get;
        }
        List<string> ChangeLetterPosition
        {
            get;
        }
    }
}
