using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public string? Inquery { get; init; }
        public string? RightChoice { get; init; }
        public string? WrongChoice { get; init; }
        public List<string>? Options { get; init;}
        public string? Answer { get; init; }
        public string? Explanation { get; init; }
    }
}
