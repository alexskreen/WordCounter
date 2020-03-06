  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCounter.Models
{
    public class UserInput
    {
      public string UserWord { get; set; }
      public string Sentence { get; set; }
      public int occurance { get; set; }
      public string[] SentenceArr { get; set; }

      public UserInput(string userWord, string sentence)
      {
        UserWord = UserWord;
        Sentence = sentence;
      }

        public string WordToUpperCase(string UserWord)
        {
        string upperWord = UserWord.ToUpper();
        return upperWord;
        }

        public string SentenceToUpperCase()
        {
        string upperSentence = Sentence.ToUpper();
        return upperSentence;
        }

        public int SentenceToArr()
        {
        string[] SentenceArr = Sentence.Split(' ');
        // return SentenceArr.Length;
          return SentenceArr.Length;
        }

        public int CompareWord(string UserWord)
        {
          int userWordCount = 0;
          string[] SentenceArr = Sentence.Split(' ');
          foreach (string word in SentenceArr)
          {
            if (word == UserWord)
            {
            userWordCount += 1;
            }
          }
          return userWordCount;
        }




      }
    }