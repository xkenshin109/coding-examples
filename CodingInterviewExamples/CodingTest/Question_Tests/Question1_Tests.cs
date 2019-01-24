using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples;
using CodingInterviewExamples.Interface;
using CodingInterviewExamples.Questions;
namespace CodingTest
{
    [TestClass]
    public class Question1_Tests
    {
        [TestMethod]
        public void Returns4()
        {
            ICodingQuestion _question1 = new Question1(new int[] { 1, 4, 4, 2, 4, 2, 4, 4 });
            _question1.Run();
            Assert.AreEqual(((Question1)(_question1))._result, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "There was no number found.")]
        public void NoneFoundThrowsException()
        {
            ICodingQuestion _question1 = new Question1(new int[] { 1, 4, 5, 2, 4, 2, 4 });
            _question1.Run();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There are no items in the array")]
        public void NoItemsInArrayThrowsException()
        {
            ICodingQuestion _question = new Question1(new int[] { });
            _question.Run();
        }
    }
}
