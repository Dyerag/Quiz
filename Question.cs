using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        //todo move the theme field elsewhere
        //gonna have to alter it aswell, but havent figured out how to get the theme of the quiz, as its from the same json file
        public string? Theme { get; }
        public string? Inquery { get; }
        public string? RightChoice { get; }
        public string? WrongChoice { get; }
        public List<string>? Options { get; }
        public string? Answer { get; }
        public string? Explanation { get; }

    }
}
