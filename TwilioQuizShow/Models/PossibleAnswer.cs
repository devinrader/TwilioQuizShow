using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioQuizShow.Models
{
    public class PossibleAnswer
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public int Order { get; set; }

        public bool IsCorrect { get; set; }
    }
}