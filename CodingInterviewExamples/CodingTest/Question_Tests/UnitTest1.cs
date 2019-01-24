using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewExamples.Interface;
using CodingInterviewExamples.Questions;

namespace CodingTest.Question_Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    /// 
    //LinkedListStack list = new LinkedListStack();
    //list.Push("pushed first");
    //list.Push("pushed second");
    //list.Push("pushed third");
    //Console.WriteLine(list.DetectCycle());
    //list.CreateCycle();
    //Console.WriteLine(list.DetectCycle());
    [TestClass]
    public class Question2_Tests
    {
        public Question2_Tests()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            ICodingQuestion _q = new Question2();
        }
    }
}
