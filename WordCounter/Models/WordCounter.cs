
using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class UserInput
  {
    public string UserWord { get; set; }
    public string Sentence { get; set; }
    public UserInput(string userWord, string sentence)
    {
      UserWord = userWord;
      Sentence = sentence;
    }

    public string CheckForNumbers()
    {
      if (UserWord.Contains("1") || UserWord.Contains("2") || UserWord.Contains("3") || UserWord.Contains("4") || UserWord.Contains("5") || UserWord.Contains("6") || UserWord.Contains("7") || UserWord.Contains("8") || UserWord.Contains("9") || UserWord.Contains("0"))
      {
        return "Please enter a valid word";
      }
      else
      {
        return UserWord;
      }
    }

    public string WordToLowerCase()
    {
      string lowerWord = UserWord.ToLower();
      UserWord = lowerWord;
      return lowerWord;
    }

    public string SentenceToLowerCase()
    {
      string lowerSentence = Sentence.ToLower();
      Sentence = lowerSentence;
      return lowerSentence;
    }

    public int CompareWord()
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