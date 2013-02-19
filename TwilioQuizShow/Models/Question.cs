using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioQuizShow.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int Difficulty { get; set; }

        public string Category { get; set; }

        public string Text { get; set; }

        public List<PossibleAnswer> PossibleAnswers { get; set; }
    }
}