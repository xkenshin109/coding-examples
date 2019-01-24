using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples.Interface;
using CodingInterviewExamples.Questions;

namespace CodingTest
{

    [TestClass]
    public class Question2_Tests
    {
        public Question2_Tests()
        {
        }

        [TestMethod]
        public void CreateCycle()
        {
            Question2 q = new Question2(new string[] 
            {
                "pushed first",
                "pushed second",
                "pushed third",
            });
            Assert.AreEqual(q.DetectCycle, false);
            q.Run();
            Assert.AreEqual(q.DetectCycle, true);
        }
    }
}
