using System;
using System.Collections.Generic;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToRead = "../../../../text.txt";
            string fileToWrite = "../../../../text_edited.txt";

            ChangeLog changeLog = new ChangeLog();
            StreamReader sr = new StreamReader(fileToRead);
            StreamWriter sw = new StreamWriter(fileToWrite);
            TextEditor textEditor = new TextEditor();
            TextEditorController textEditorController = new TextEditorController(changeLog, sr, sw, textEditor);
            textEditorController.EditText();
        }
    }
}

