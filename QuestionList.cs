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
        private List<Question> _questions;
        public string Theme { get; init; }
        public List<Question> Questions
        {
            get => _questions;

            // Randomizes the order of questions before initiating it
            init
            {
                Random rnd = new Random();
                List<int> Picked = new();
                List<Question> order = new();

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
                _questions = order;
            }
        }
        public int TotalCorrectAnswers { get; set; } = 0;
    }
}
