using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Quiz
{
    public class QuestionList
    {
        public string Theme { get; init; }
        public List<Question> Questions { get; init; }
        public int TotalCorrectAnswers { get; set; } = 0;

    }
}
