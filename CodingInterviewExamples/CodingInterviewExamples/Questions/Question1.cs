using CodingInterviewExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExamples.Questions
{
    public class Question1: ICodingQuestion 
    {
        /* Given an unsorted array which has a number in the majority
         * (a number appears more than 50% in the array), 
         * find that number?*/

        public int[] _param1;
        public int? _result;
        public Question1(int[] param1)
        {
            _param1 = param1;
        }
        public void Run() {
            //Validate we have items in our Array
            if (_param1.Count() == 0) throw new ArgumentException("There are no items in the array");
            //This is where are grouping the Arrays, we will be looking for one that appears more than 50% of the time
            var o = _param1.GroupBy(x => x);
            var majority = _param1.Count() / 2;
            foreach(var item in o)
            {
                var count = item.Count();

                if(count > majority)
                {
                    //Once we have found the magic number that appears more than 50% store it in the results. 
                    _result = item.Key;
                    Console.WriteLine("Found");
                }
            }
            if(_result == null) throw new Exception("There was no number found.");
        }
    }
    
}
