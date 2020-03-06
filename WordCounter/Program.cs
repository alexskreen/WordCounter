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
            Console.ForegroundColor = ConsoleColor.Green;
            Program.TypeLine("Welcome to WordCounter!");
            Console.Write(Environment.NewLine);
            Program.TypeLine("This program will allow you to enter a word, enter a sentence, then it will tell you how many times your word occurs in the sentence!");
            Console.Write(Environment.NewLine);
            Program.TypeLine("Isn't that exciting?!");
            Console.Write(Environment.NewLine);
            Program.TypeLine("Please enter a word: ");
            Console.Write(Environment.NewLine);
            Console.Clear();
            string userInputWord = Console.ReadLine();
            Program.TypeLine("Please enter a sentence: ");
            Console.Write(Environment.NewLine);
            string userInputSentence = Console.ReadLine();
            UserInput NewUserInput = new UserInput(userInputWord, userInputSentence);
            NewUserInput.CheckForNumbers();
            NewUserInput.WordToUpperCase();
            NewUserInput.SentenceToUpperCase();
            NewUserInput.SentenceToArr();
            Program.TypeLine("The word " + NewUserInput.UserWord + " occurs " + NewUserInput.CompareWord() + " time(s) in this sentence!");

      Console.WriteLine(NewUserInput.CompareWord());
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