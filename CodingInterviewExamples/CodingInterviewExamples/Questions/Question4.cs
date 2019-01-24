using CodingInterviewExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExamples.Questions
{
    public class Question4: ICodingQuestion
    {
        public bool Result { get; set; }
        private string _word1, _word2;
        public Question4(string word1, string word2)
        {
            _word1 = word1;
            _word2 = word2;
        }
        public void Run()
        {
            char[] word1Chars = _word1.ToLowerInvariant().ToCharArray();
            char[] word2Chars = _word2.ToLowerInvariant().ToCharArray();

            Array.Sort(word1Chars);
            Array.Sort(word2Chars);

            string newWord1 = new string(word1Chars);
            string newWord2 = new string(word2Chars);

            Result = (newWord2 == newWord1);
        }
    }
}
