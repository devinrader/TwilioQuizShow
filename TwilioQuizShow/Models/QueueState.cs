using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioQuizShow.Models
{
    public class QueueState
    {        
        public QueueState(string callsid) {
            this.CallSid = callsid;
            this.Questions = new List<Question>();
            this.PlayQuizShow = true;
        }

        public string CallSid { get; set; }

        public bool PlayQuizShow { get; set; }

        public List<Question> Questions { get; set; }

        public List<SelectedAnswer> SelectedAnswers { get; set; }

        public Question CurrentQuestion { get; set; }

        public string Source { get; set; }

        public void Save()
        {
            var states = QueueStates;

            if (states.ContainsKey(this.CallSid))
            {
                states[this.CallSid] = this;
            }
            else
            {
                states.Add(this.CallSid, this);
            }

            // Save the QueueState to Cache.  In a real system this would likely
            // be something more robust like a database

            System.Web.HttpContext.Current.Cache["QueueStateCache"] = states;
        }

        public static QueueState Load(string callsid)
        {
            if (QueueStates.ContainsKey(callsid))
                return QueueStates[callsid];
            else
                return null;
        }

        public static QueueState CreateAndSave(string callsid)
        {
            if (string.IsNullOrEmpty(callsid))
            {
                throw new ArgumentException("CallSid cannot be null or empty");
            }

            var queue = new QueueState(callsid);

            queue.Save();

            return queue;
        }

        private static Dictionary<string, QueueState> QueueStates
        {
            get
            {
                Dictionary<string, QueueState> queueStates = (Dictionary<string, QueueState>)System.Web.HttpContext.Current.Cache["QueueStateCache"];

                if (queueStates == null)
                {
                    queueStates = new Dictionary<string, QueueState>();
                    System.Web.HttpContext.Current.Cache["QueueStateCache"] = queueStates;
                }

                return queueStates;
            }
        }


    }
}