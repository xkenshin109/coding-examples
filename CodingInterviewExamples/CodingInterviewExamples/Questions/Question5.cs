using CodingInterviewExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExamples.Questions
{
    public class Question5: ICodingQuestion
    {
        public int First { get; private set; }
        public int Second { get; private set; }

        public Question5(int first,int second)
        {
            First = first;
            Second = second;
        }
        public void RunXor()
        {
            First = First ^ Second;
            Second = Second ^ First;
            First = First ^ Second;
        }
        //Swap two integers without using a temp variable
        public void Run() {
            First = First + Second;
            Second = First - Second;
            First = First - Second;
            
        }
    }
}
