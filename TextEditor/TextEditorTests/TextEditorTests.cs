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
        [InlineData("Jag tycker om hösten, hösten är bäst!", "hösten", "vintern", "Jag tycker om vintern, vintern är bäst!")]
        [InlineData("Jag är verkligen kall, är du kall?", @"(?<=v[\S]*\s)kall", "varm", "Jag är verkligen varm, är du kall?")]
        [InlineData("Med stöd av alla, äppelkaka av alla.", @"(?<=\bs[\S]*\s)av", "från", "Med stöd från alla, äppelkaka av alla.")]
        [InlineData("Hej då", "Hej då", "Hejdå", "Hejdå")]
        [InlineData("jag saknar pizza. jag älskar pizza", @"(?<=\bs[\S]*\s)pizza", "hamburgare", "jag saknar hamburgare. jag älskar pizza")]
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
        [InlineData("Här är en testmening", "är", "Här Är en testmening")]
        public void Should_Change_To_Upper_Case_Letter(string inputText, string wordToChange, string correctText)
        {
            string editedText = textEditor.ChangeToCapitalLetter(inputText, wordToChange);
            Assert.Equal(correctText, editedText);
        }

        [Theory]
        [InlineData("Jag heter iseLou", "iseLou", "Jag heter Louise" )]
        [InlineData("Jag jobbar på frontFore", "frontFore", "Jag jobbar på Forefront")]
        public void Should_switch_placement_of_letters_in_word(string inputText, string wordToChange, string correctText)
        {
            string editedText = textEditor.ChangeLetterPositions(inputText, wordToChange);
            Assert.Equal(correctText, editedText);

        }
    }
}
