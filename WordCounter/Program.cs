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
            Program.TypeLine("Welcome to WordCounter!");
            Console.Write(Environment.NewLine);
            Program.TypeLine("This program will allow you to enter a word, enter a sentence, then it will tell you how many times your word occurs in the sentence!");
            Console.Write(Environment.NewLine);
            Program.TypeLine("Isn't that exciting?!");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Please enter a word: ");
            Console.Write(Environment.NewLine);
            string userInputWord = Console.ReadLine();
            Console.WriteLine("Please enter a sentence: ");
            Console.Write(Environment.NewLine);
            string userInputSentence = Console.ReadLine();
            UserInput NewUserInput = new UserInput(userInputWord, userInputSentence);
            NewUserInput.CheckForNumbers();
            NewUserInput.WordToUpperCase();
            NewUserInput.SentenceToUpperCase();
            NewUserInput.SentenceToArr();
            Console.WriteLine(NewUserInput.CompareWord());
            // Program.TypeLine(NewUserInput.CompareWord());





      Program.TypeLine(NewUserInput.UserWord);
            

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