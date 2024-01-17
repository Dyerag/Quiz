using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    /// <summary>
    /// The actual game
    /// </summary>
    public class Game
    {
        public QuestionList Questions { get; set; }
        public Game()
        {
            IO setup = new();
            Questions = setup.FileFetch();

            Program.Intro(Questions);
            Play();

        }

        public void Play()
        {
            int questionNumber = 1;

            //do
            //{
               foreach(Question item in Questions.Questions) 

                GUI.Print(/*"Spørgsmål #" +*/item.Ask,0,200 );

            //} while (Questions.QuestionOrder.Count > 0);
        }

        private void Transition()
        {

        }

    }
}
