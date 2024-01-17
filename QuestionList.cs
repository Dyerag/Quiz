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
        // Init body causes the program, and even visual studio to essentially crash. Technically it freezes, with a bunch of data in the window, bit ot lasted a couple minutes
        public List<Question> Questions { get { return Questions; } init { Questions=SetOrder(value); } } 
        //public Queue<Question> QuestionOrder { get; set; }
        public int TotalCorrectAnswers { get; set; } = 0;

        public List<Question> SetOrder(List<Question> amount)
        {
            Random rnd = new Random();
            List<int> Picked = new();
            List<Question> order = new();

            while (order.Count < amount.Count)
            {
                int num = 0;

                do
                {
                    num = rnd.Next(0, amount.Count);
                } while (Picked.Contains(num));

                Picked.Add(num);
                order.Add(amount[num]);
            }

            return order;
        }
    }
}
