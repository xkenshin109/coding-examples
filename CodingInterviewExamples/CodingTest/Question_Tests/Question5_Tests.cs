using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples;
using CodingInterviewExamples.Questions;
namespace CodingTest
{
    [TestClass]
    public class Question5_Tests
    {
        [TestMethod]
        public void SwappedNumbers()
        {
            Question5 q = new Question5(100, 200);
            Assert.AreEqual(q.First, 100);
            Assert.AreEqual(q.Second, 200);
            q.Run();
            Assert.AreEqual(q.First,200);
            Assert.AreEqual(q.Second, 100);
            q.RunXor();
            Assert.AreEqual(q.First, 100);
            Assert.AreEqual(q.Second, 200);
        }
    }
}
