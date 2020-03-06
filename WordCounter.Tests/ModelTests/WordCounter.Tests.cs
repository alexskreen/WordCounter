 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using WordCounter.Models;

 namespace WordCounter.Test
 {
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void WordToUpperCase_TestCat_ReturnCAT()
        {
            UserInput testUserInput = new UserInput("cat", "cats are awesome");
            Assert.AreEqual("CAT", testUserInput.WordToUpperCase("cat"));
        }

        [TestMethod]
        public void SentenceToUpperCase_TestCat_ReturnCAT()
        {
            UserInput testUserInput = new UserInput("cat", "cats are awesome");
            Assert.AreEqual("CATS ARE AWESOME", testUserInput.SentenceToUpperCase());
        }

        [TestMethod]
        public void SentenceToArr_ArrayifySentence_ReturnLength()
        {
            UserInput testUserInput = new UserInput("cat", "cats are awesome");
            Assert.AreEqual(3, testUserInput.SentenceToArr());
        }

        [TestMethod]
        public void CompareWord_CompareUserWordToString_ReturnOccurence()
        {
            UserInput testUserInput = new UserInput("cat", "my cat is the best cat");
            testUserInput.SentenceToArr();
            Assert.AreEqual(2, testUserInput.CompareWord("cat"));
        }

        [TestMethod]
        public void CompareWord_ComparePartialWordToFullWord_ReturnZero()
        {
            UserInput testUserInput = new UserInput("cat", "catalina");
            testUserInput.SentenceToArr();
            Assert.AreEqual(0, testUserInput.CompareWord("cat"));
        }

        [TestMethod]
        public void CompareWord_ComparePartialWordToFullWordInSentence_ReturnZero()
        {
            UserInput testUserInput = new UserInput("cat", "the catalina cat catastrophe was catatonic");
            testUserInput.SentenceToArr();
            Assert.AreEqual(1, testUserInput.CompareWord("cat"));
        }

        // [TestMethod]
        // public void CompareWord_ComparePartialWordToFullWordInSentence_ReturnZero()
        // {
        //     UserInput testUserInput = new UserInput("cat", "the catalina CaT catastrophe was catatonic. Luckily my CAt was ok");
        //     testUserInput.WordToUpperCase();
        //     testUserInput.SentenceToUpperCase();
        //     testUserInput.SentenceToArr();
        //     Assert.AreEqual(1, testUserInput.CompareWord("cat"));
        // }
    } 
 }