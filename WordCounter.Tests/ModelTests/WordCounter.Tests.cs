 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using WordCounter.Models;

 namespace WordCounter.Test
 {
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void ToUpperCase_TestCat_ReturnCAT()
        {
            UserInput testUserInput = new UserInput("cat", "cats are awesome");
            Assert.AreEqual("CAT", testUserInput.ToUpperCase("cat"));

        }
    } 
 }