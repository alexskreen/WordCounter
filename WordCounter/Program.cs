using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;

namespace Wordcounter.Program
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.Red;
      Program.TypeLine("Welcome to WordCounter!");
      Console.Write(Environment.NewLine);
      Program.TypeLine("This program will allow you to enter a word, enter a sentence, then it will tell you how many times your word occurs in the sentence!");
      Console.Write(Environment.NewLine);
      Program.TypeLine("Isn't that exciting?!");
      Console.Write(Environment.NewLine);
      Program.TypeLine("Please enter a word: ");
      Console.Write(Environment.NewLine);
      string userInputWord = Console.ReadLine();
      Console.Clear();
      Program.TypeLine("Please enter a sentence: ");
      Console.Write(Environment.NewLine);
      string userInputSentence = Console.ReadLine();
      UserInput newUserInput = new UserInput(userInputWord, userInputSentence);
      Console.Clear();
      newUserInput.CheckForNumbers();
      newUserInput.WordToLowerCase();
      newUserInput.SentenceToLowerCase();
      if (newUserInput.CompareWord() == 0)
      {
      Program.TypeLine("Your word doesn't occur in the sentence. Please try again!");
      }
      else
      {
      Program.TypeLine("The word " + newUserInput.UserWord + " occurs " + newUserInput.CompareWord() + " time(s) in this sentence!");
      }
    }

    public static void TypeLine(string input)
    {
      for (int i = 0; i < input.Length; i++)
      {
        Console.Write(input[i]);
        System.Threading.Thread.Sleep(25);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
    }
  }
}