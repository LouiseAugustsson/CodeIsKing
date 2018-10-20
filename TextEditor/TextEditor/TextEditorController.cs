using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TextEditor
{
    public class TextEditorController
    {
        public IChangeLog _changeLog;
        public StreamReader _sr;
        public StreamWriter _sw;
        public TextEditor _textEditor;

        public TextEditorController(IChangeLog changeLog, StreamReader sr,
            StreamWriter sw, TextEditor textEditor)
        {
            this._changeLog = changeLog;
            this._sr = sr;
            this._sw = sw;
            this._textEditor = textEditor;
        }

        public void EditText()
        {
            string line;

            while ((line = this._sr.ReadLine()) != null)
            {
                foreach (var item in this._changeLog.ReplaceWords)
                {
                    line = this._textEditor.ReplaceWord(line, item.Key, item.Value);
                }

                foreach (var item in this._changeLog.ReverseWords)
                {
                    line = this._textEditor.ReverseWord(line, item);
                }

                foreach (var item in this._changeLog.ToCapitalLetters)
                {
                    line = this._textEditor.ChangeToCapitalLetter(line, item);
                }

                foreach (var item in this._changeLog.ChangeLetterPosition)
                {
                    line = this._textEditor.ChangeLetterPositions(line, item);
                }
               this._sw.WriteLine(line);
            }
            this._sw.Close();
            return;
        }
    }
}
