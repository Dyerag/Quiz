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
        private int _totalCorrectAnswers = 0;
        public string Theme { get; }
        public List<Question> Questions { get; }
        public int TotalCorrectAnswers
        {
            get => _totalCorrectAnswers;
            set => _totalCorrectAnswers++;
        }
    }
}
