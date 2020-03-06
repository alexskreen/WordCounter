  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
    public class UserInput
    {
      public string Word { get; set;}
      public string Sentence { get; set;}
      public int occurance { get; set;}

      public UserInput(string word, string Sentence)
      {
        Word = word;
        Sentence = Sentence;
      }

        public string WordToUpperCase(string Word)
        {
        string upperWord = Word.ToUpper();
        return upperWord;
        }

        public string SentenceToUpperCase(string Sentence)
        {
        string upperSentence = Sentence.ToUpper();
        return upperSentence;
        }




      }
    }