using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioQuizShow.Models
{
    public class QuizShowState
    {
        public QuizShowState(string callsid)
        {
            this.CallSid = callsid;
            this.Questions = new List<Question>();
            this.CurrentQuestionIndex = 0;
            this.SelectedAnswers = new List<SelectedAnswer>();
        }

        public string CallSid { get; private set; }

        public List<Question> Questions { get; set; }

        public int CurrentQuestionIndex { get; set; }

        public List<SelectedAnswer> SelectedAnswers { get; set; }

        public int CorrectAnswerCount { get; set; }

        public void Save()
        {
            var states = QuizShowStates;

            if (states.ContainsKey(this.CallSid))
            {
                states[this.CallSid] = this;
            }
            else 
            {
                states.Add(this.CallSid, this);
            }

            System.Web.HttpContext.Current.Cache["QuizShowStateCache"] = states;
        }

        public static QuizShowState Load(string callsid)
        {
            if (QuizShowStates.ContainsKey(callsid))
                return QuizShowStates[callsid];
            else
                return null;
        }

        public static QuizShowState CreateAndSave(string callsid)
        {
            if (string.IsNullOrEmpty(callsid))
            {
                throw new ArgumentException("CallSid cannot be null or empty");
            }

            var quizShow = new QuizShowState(callsid);

            QuizShowViewModel vm = new QuizShowViewModel();

            int max = vm.Questions.Count;

            int[] indexes = new int[5];

            Random rand = new Random(Environment.TickCount);

            int counter = 0;
            while (counter < 5)
            {
                int index = rand.Next(max);

                if (!indexes.Contains(index))
                {
                    indexes[counter] = index;
                    quizShow.Questions.Add(vm.Questions[index]);
                    counter++;
                }
            }

            quizShow.Save();

            return quizShow;
        }

        private static Dictionary<string, QuizShowState> QuizShowStates
        {
            get
            {
                Dictionary<string, QuizShowState> quizShowStates = (Dictionary<string, QuizShowState>)System.Web.HttpContext.Current.Cache["QuizShowStateCache"];

                if (quizShowStates == null)
                {
                    quizShowStates = new Dictionary<string, QuizShowState>();
                    System.Web.HttpContext.Current.Cache["QuizShowStateCache"] = quizShowStates;
                }

                return quizShowStates;
            }
        }
    }
}