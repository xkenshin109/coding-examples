using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples;
using CodingInterviewExamples.Questions;
namespace CodingTest
{
    [TestClass]
    public class Question4_Tests
    {
        [TestMethod]
        public void WordsAreAnagrams()
        {
            Question4 q = new Question4("Silent","Listen");
            q.Run();
            Assert.AreEqual(q.Result, true);
        }
    }
}
