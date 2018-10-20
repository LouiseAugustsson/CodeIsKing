using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TextEditor
{
    public class TextEditor
    {
        public string ReplaceWord(string text, string oldWord, string newWord)
        {
            text = Regex.Replace(text, oldWord, newWord, RegexOptions.IgnoreCase);
            return text;
        }

        public string ReverseWord(string text, string oldWord)
        {
            char[] reversed_word_char = oldWord.ToCharArray();
            Array.Reverse(reversed_word_char);
            string newWord = new string(reversed_word_char);
            text = Regex.Replace(text, oldWord, newWord);
            return text;
        }

        public string ChangeToCapitalLetter(string text, string oldWord, int position = 0)
        {
            StringBuilder strBuilder = new StringBuilder(oldWord);
            strBuilder[position] = Char.ToUpper(oldWord[position]);
            string newWord = strBuilder.ToString();
            text = Regex.Replace(text, @"\b" + oldWord + @"\b", newWord);
            return text;
        }

        public string ChangeLetterPositions(string text, string oldWord)
        {
            string newWord = "";

            int position = oldWord.Length / 2;
            if (oldWord.Length % 2 == 0)
            {
                newWord = oldWord.Substring(position, position) + oldWord.Substring(0, position);
            }
            else
            {
                newWord = oldWord.Substring(position + 1, position) + oldWord.Substring(0, position + 1);
            }
            text = Regex.Replace(text, @"\b" + oldWord + @"\b", newWord);
            return text;
        }
    }
}
