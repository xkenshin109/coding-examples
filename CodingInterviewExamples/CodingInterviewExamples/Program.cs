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
            Question3 q = new Question3();
            q.Run();
            //Questions = new List<ICodingQuestion>
            //{
            //    new Question1(new int[]{1,4,5,2,4,2,4,4 })
            //};
            //Questions.ForEach(process =>
            //{
            //    process.Run();
            //});
        }
    }
}
