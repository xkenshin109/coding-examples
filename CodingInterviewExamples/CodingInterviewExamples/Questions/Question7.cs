using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingInterviewExamples;
using CodingInterviewExamples.Interface;
namespace CodingInterviewExamples.Questions
{
    public class Question7: ICodingQuestion
    {
        private int _nth;
        public int Result { get; set; }
        public Question7(int nth)
        {
            _nth = nth;
        }
        public void Run()
        {
            List<int> fibArray = new List<int>();
            fibArray.Add(0);
            fibArray.Add(1);
            for(var x = 2; x< _nth; x++)
            {
                if(x - 2 >= 0)
                {
                    fibArray.Add(fibArray[x - 1] + fibArray[x - 2]);
                }
                else if( x-1 >= 0)
                {
                    fibArray.Add(fibArray[x - 1]);
                }
                else
                {
                    fibArray.Add(x);
                }
            }
            Result = fibArray[_nth - 1];
        }
    }
}
