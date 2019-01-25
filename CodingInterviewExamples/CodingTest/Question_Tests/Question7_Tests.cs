using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples;
using CodingInterviewExamples.Questions;
namespace CodingTest
{
    [TestClass]
    public class Question7_Tests
    {
        [TestMethod]
        public void Returns10th()
        {
            Question7 q = new Question7(10);
            q.Run();
            Assert.AreEqual(q.Result, 34);
        }
    }
}
