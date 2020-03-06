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
            Assert.AreEqual("CATS ARE AWESOME", testUserInput.SentenceToUpperCase("cats are awesome"));
        }

        [TestMethod]
        public void SentenceToArr_ArrayifySentence_ReturnLength()
        {
            UserInput testUserInput = new UserInput("cat", "cats are awesome");
            Assert.AreEqual(10, testUserInput.SentenceToArr("cats are awesome"));

        }
    } 
 }