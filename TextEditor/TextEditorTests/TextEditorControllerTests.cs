using System;
using Xunit;
using System.IO;
using TextEditor;

namespace TextEditorTests
{
    public class TextEditorControllerTests
    {
        readonly ChangeLogForTests changeLog = new ChangeLogForTests();
        readonly StreamReader sr = new StreamReader("../../../../../../../../text_for_tests.txt");
        readonly StreamWriter sw = new StreamWriter("../../../../../../../../text_for_test_edited.txt");
        readonly TextEditor.TextEditor textEditor = new TextEditor.TextEditor();
        readonly TextEditorController textEditorController;
        public TextEditorControllerTests()
        {
            this.textEditorController = new TextEditorController(changeLog, sr, sw, textEditor);
        }

        [Fact]
        public void EditedTextShouldReturnCorrectText()
        {

            textEditorController.EditText();
            StreamReader srCorrect = new StreamReader("../../../../../../../../text_for_test_edited.txt");
            StreamReader srEdited = new StreamReader("../../../../../../../../text_for_tests_edited_correct.txt");
            string textCorrect = srCorrect.ReadToEnd();
            string textEdited = srEdited.ReadToEnd();
            Assert.Equal(textCorrect, textEdited);
        }

    }
}
