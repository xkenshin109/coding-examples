using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingInterviewExamples.Interface;
using CodingInterviewExamples.Questions;
namespace CodingInterviewExamples
{
    class Program
    {
        private static List<ICodingQuestion> Questions { get; set; }
        static void Main(string[] args)
        {
            //Question6 q = new Question6(
            //    new int[] { 4, 2, 4, 4 },
            //    6);
            Question7 q = new Question7(12);
            q.Run();

        }
    }
}
