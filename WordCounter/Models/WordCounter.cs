  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
    public class UserInput
    {
      public string Word { get; set; }
      public string Sentence { get; set; }
      public int occurance { get; set; }
      public string[] SentenceArr { get; set; }

      public UserInput(string word, string sentence)
      {
        Word = word;
        Sentence = sentence;
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

        public int SentenceToArr(string Sentence)
        {
        string[] SentenceArr = Sentence.Split(' ');

        // foreach (string word in Sentence)
        // {
        //     SentenceArr.Add(word);
        //     System.Console.WriteLine($"<{word}>");
        // }
        return SentenceArr.Length;
        }




      }
    }