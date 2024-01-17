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
        public Queue<Question> QuestionOrder { get; set; }
        public int TotalCorrectAnswers { get; set; } = 0;

        public void SetOrder()
        {
            Random rnd = new Random();
            List<int> Picked = new();
            Queue<Question> order = new();

            while (order.Count != this.Questions.Count)
            {
                int num = 0;

                do
                {
                    num = rnd.Next(0, Questions.Count);
                } while (Picked.Contains(num));

                Picked.Add(num);
                order.Enqueue(Questions[num]);
            }

            QuestionOrder = order;
        }
    }
}
