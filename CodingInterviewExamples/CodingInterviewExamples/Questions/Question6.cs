using CodingInterviewExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExamples.Questions
{
    public class Question6: ICodingQuestion
    {
        private int[] _param;
        private int _number;
        public bool Result { get; set; }
        public Question6(int[] param, int number)
        {
            //Given an array and an integer
            //Find if any two numbers in the array sums to the given Number
            _param = param;
            _number = number;
        }
        public void Run() {
            for(var x =0; x<_param.Length;x++)
            {
                for(var y = 0; y<_param.Length; y++)
                {
                    if(x != y && _param[x] + _param[y] == _number)
                    {
                        Result = true;
                    }
                }
            }
        }
    }
}
