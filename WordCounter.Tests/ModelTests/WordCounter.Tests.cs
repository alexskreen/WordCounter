using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void CheckForNumbers_TestNumber_ReturnWord()
    {
      UserInput testUserInput = new UserInput("1", "cats are awesome");
      Assert.AreEqual("Please enter a valid word", testUserInput.CheckForNumbers());
    }

    [TestMethod]
    public void CheckForNumbers_TestWordWithNumbers_ReturnWord()
    {
      UserInput testUserInput = new UserInput("cat1", "cats are awesome");
      Assert.AreEqual("Please enter a valid word", testUserInput.CheckForNumbers());
    }

    [TestMethod]
    public void WordToLowerCase_TestCat_ReturnCAT()
    {
      UserInput testUserInput = new UserInput("cat", "cats are awesome");
      Assert.AreEqual("cat", testUserInput.WordToLowerCase());
    }

    [TestMethod]
    public void SentenceToLowerCase_TestCat_ReturnCAT()
    {
      UserInput testUserInput = new UserInput("cat", "cats are awesome");
      Assert.AreEqual("cats are awesome", testUserInput.SentenceToLowerCase());
    }

    [TestMethod]
    public void CompareWord_CompareUserWordToString_ReturnOccurence()
    {
      UserInput testUserInput = new UserInput("cat", "my cat is the best cat");
      Assert.AreEqual(2, testUserInput.CompareWord());
    }

    [TestMethod]
    public void CompareWord_ComparePartialWordToFullWord_ReturnOccurence()
    {
      UserInput testUserInput = new UserInput("cat", "catalina");
      Assert.AreEqual(0, testUserInput.CompareWord());
    }

    [TestMethod]
    public void CompareWord_ComparePartialWordToFullWordInSentence_ReturnOccurence()
    {
      UserInput testUserInput = new UserInput("cat", "the catalina cat catastrophe was catatonic");
      Assert.AreEqual(1, testUserInput.CompareWord());
    }

    [TestMethod]
    public void CompareWord_CompareSentenceWithMixedCharactersAndPartialWords_ReturnOccurence()
    {
      UserInput testUserInput = new UserInput("cat", "the catalina CaT catastrophe was catatonic. Luckily my CAT was ok");
      testUserInput.WordToLowerCase();
      testUserInput.SentenceToLowerCase();
      Assert.AreEqual(2, testUserInput.CompareWord());
    }
  }
}