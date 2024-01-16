using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Quiz
{
    public class QuestionList
    {
        public string Theme { get; }
        public List<Question> Questions { get; }
        public int TotalCorrectAnswers { get; set; } = 0;
    }
}
