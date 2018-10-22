using System;
using Xunit;
using TextEditor;

namespace TextEditorTests
{
    public class TextEditorTests
    {
        readonly TextEditor.TextEditor textEditor; 
        public TextEditorTests()
        {
            textEditor = new TextEditor.TextEditor();
        }
    
        [Theory]
        [InlineData("Jag tycker om h�sten, h�sten �r b�st!", "h�sten", "vintern", "Jag tycker om vintern, vintern �r b�st!")]
        [InlineData("Jag �r verkligen kall, �r du kall?", @"(?<=v[\S]*\s)kall", "varm", "Jag �r verkligen varm, �r du kall?")]
        [InlineData("Med st�d av alla, �ppelkaka av alla.", @"(?<=\bs[\S]*\s)av", "fr�n", "Med st�d fr�n alla, �ppelkaka av alla.")]
        [InlineData("Hej d�", "Hej d�", "Hejd�", "Hejd�")]
        [InlineData("jag saknar pizza. jag �lskar pizza", @"(?<=\bs[\S]*\s)pizza", "hamburgare", "jag saknar hamburgare. jag �lskar pizza")]
        public void Should_replace_old_word_with_new_word(string inputText, string wordToReplace, string wordToReplaceWith, string correctText)
        {
            string editedText = textEditor.ReplaceWord(inputText, wordToReplace, wordToReplaceWith);
            Assert.Equal(correctText, editedText);
        }

        [Theory]
        [InlineData("Jag tycker om nerammos", "nerammos", "Jag tycker om sommaren")]
        public void Should_Reverse_Word(string inputText, string wordToChange, string correctText)
        {
            string editedText = textEditor.ReverseWord(inputText,wordToChange);
            Assert.Equal(correctText, editedText);
        }

        [Theory]
        [InlineData("Jag heter louise", "louise", "Jag heter Louise")]
        [InlineData("H�r �r en testmening", "�r", "H�r �r en testmening")]
        public void Should_Change_To_Upper_Case_Letter(string inputText, string wordToChange, string correctText)
        {
            string editedText = textEditor.ChangeToCapitalLetter(inputText, wordToChange);
            Assert.Equal(correctText, editedText);
        }

        [Theory]
        [InlineData("Jag heter iseLou", "iseLou", "Jag heter Louise" )]
        [InlineData("Jag jobbar p� frontFore", "frontFore", "Jag jobbar p� Forefront")]
        public void Should_switch_placement_of_letters_in_word(string inputText, string wordToChange, string correctText)
        {
            string editedText = textEditor.ChangeLetterPositions(inputText, wordToChange);
            Assert.Equal(correctText, editedText);

        }
    }
}
