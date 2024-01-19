using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        private List<string> _options;

        public string? Ask { get; init; }
        public string? RightChoice { get; init; }
        public string? WrongChoice { get; init; }
        public string? Answer { get; init; }
        public string? Explanation { get; init; }
        public List<string> Options
        {
            get => _options;
            init
            {
                Random rnd = new Random();
                List<int> Picked = new();
                List<string> order = new();

                while (order.Count < value.Count)
                {
                    int num = 0;

                    do
                    {
                        num = rnd.Next(0, value.Count);
                    } while (Picked.Contains(num));

                    Picked.Add(num);
                    order.Add(value[num]);
                }
                _options = order;
            }
        }
    }
}
