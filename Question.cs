using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public string? Inquery { get; }
        public string? RightChoice { get; }
        public string? WrongChoice { get; }
        public List<string>? Options { get; }
        public string? Answer { get; }
        public string? Explanation { get; }

    }
}
