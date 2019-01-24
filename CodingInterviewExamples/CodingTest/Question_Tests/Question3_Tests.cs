using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples;
using CodingInterviewExamples.Interface;
using CodingInterviewExamples.Questions;
namespace CodingTest
{
    [TestClass]
    public class Question3_Tests
    {
        [TestMethod]
        public void MergeTwoLinkedLists()
        {
            //We will be merging two lists
            Question3 q = new Question3(
                new int[] { 2,4,3,2,1},
                new int[] { 7,2,3,4,5});
            q.Run();
            Assert.AreEqual(q.Result, "1,2,2,2,3,3,4,4,5,7");
        }
    }
}
