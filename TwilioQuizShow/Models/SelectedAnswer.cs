using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioQuizShow.Models
{
    public class SelectedAnswer
    {
        public string QuestionId { get; set;}

        public string PossibleAnswerId { get; set; }
    }
}