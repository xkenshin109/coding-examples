using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples;
using CodingInterviewExamples.Questions;
namespace CodingTest
{
    [TestClass]
    public class Question6_Tests
    {
        [TestMethod]
        public void ReturnsTrue()
        {
            Question6 q = new Question6(
                new int[] { 6, 2, 4, 7, 8, 2 },
                12);
            q.Run();
            Assert.AreEqual(q.Result, true);
        }
        [TestMethod]
        public void ReturnsFalse()
        {
            Question6 q = new Question6(
                new int[] { 6, 2, 4, 7, 8, 2 },
                16);
            q.Run();
            Assert.AreEqual(q.Result, false);
        }
        [TestMethod]
        public void ReturnsFalse_NoArray()
        {
            Question6 q = new Question6(
                new int[] {  },
                12);
            q.Run();
            Assert.AreEqual(q.Result, false);
        }
    }
}
