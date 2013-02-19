using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Mvc;
using TwilioQuizShow.Models;

namespace TwilioQuizShow.Controllers
{
    public class QuizShowController : TwilioController
    {
        //
        // GET: /QuizShow/

        public ActionResult QuizShowInvitationRedirect(string CallSid)
        {          
            var gameState = QuizShowState.Load(CallSid);

            if (gameState != null)
            {
                return RedirectToAction("PlayAgainInvitation");
            }
            return RedirectToAction("PlayInvitation");
        }

        [HttpGet]
        public ActionResult PlayInvitation(string CallSid)
        {
            var response = new TwilioResponse();
            
            response.BeginGather(
                new { 
                    action = Url.ActionAbsolute("PlayInvitation"), 
                    method = "POST",
                    numDigits = "1",
                    timeout="3"
                });

            response.Say("Lets play a game while you wait.");
            response.Say("If you would rather just listen to music, press 1");
            response.EndGather();

            response.Redirect(Url.ActionAbsolute("Introduction"), "GET");

            return TwiML(response);
        }

        [HttpGet]
        public ActionResult PlayAgainInvitation(string CallSid)
        {
            var response = new TwilioResponse();

            response.BeginGather(
                new
                {
                    action = Url.ActionAbsolute("PlayInvitation"),
                    method = "POST",
                    numDigits = "1",
                    timeout = "3"
                });

            response.Say("Lets play another game!");
            response.Say("If you want to just listen to music, press 1");
            response.EndGather();

            response.Redirect(Url.ActionAbsolute("Introduction"), "GET");

            return TwiML(response);
        }

        [HttpPost]
        public ActionResult PlayInvitation(string CallSid, string Digits)
        {
            var state = QueueState.Load(CallSid);

            switch (Digits)
            {
                case "1":

                    state.PlayQuizShow = false;
                    state.Save();

                    return RedirectToAction("BasicWaitExperienceRedirect", "BasicWait", new { CallSid = CallSid });

                default:

                    state.PlayQuizShow = true;
                    state.Save();

                    return RedirectToAction("Introduction");
            }
        }

        public ActionResult Introduction(string CallSid)
        {
            var quizShow = QuizShowState.CreateAndSave(CallSid);

            var response = new TwilioResponse();

            response.Say("Welcome to the Twilio Quiz Show!  Playing the game is simple.  Just answer 5 trivia questions.");
            response.Say("Are you ready? . ");

            response.Redirect(Url.ActionAbsolute("ReadQuestion"), "GET");
            return TwiML(response);
        }

        [HttpGet]
        public ActionResult ReadQuestion(string CallSid)
        {
            var gameState = QuizShowState.Load(CallSid);
            var currentQuestion = gameState.Questions[gameState.CurrentQuestionIndex];

            var response = new TwilioResponse();
            response.Say(". OK.  Here is question number " + (gameState.CurrentQuestionIndex + 1).ToString() + ". .");
             
            response.BeginGather(
                new
                {
                    action = Url.ActionAbsolute("CaptureAnswer"),
                    method = "POST",
                    numDigits = "1",
                    timeout = "5"
                });

            response.Say(string.Format("{0}? . . ", currentQuestion.Text));
            response.Say("Is the answer. . ");

            var orderedAnswers = currentQuestion.PossibleAnswers.OrderBy(a => a.Order).ToList();
            for (int i = 0; i < orderedAnswers.Count(); i++)
            {
                if ( i == (orderedAnswers.Count() - 1) )
                {
                    response.Say(string.Format("Or. {0}. {1}. . ", (i + 1).ToString(), orderedAnswers[i].Text));                    
                }
                else
                {
                    response.Say(string.Format(". {0}. {1}. . ", (i + 1).ToString(), orderedAnswers[i].Text));                    
                }
            }

            response.EndGather();
            response.Redirect(Url.ActionAbsolute("NoAnswerProvided"), "GET");

            gameState.Save();
            return TwiML(response);
        }

        public ActionResult NoAnswerProvided(string CallSid)
        {
            var gameState = QuizShowState.Load(CallSid);

            var response = new TwilioResponse();

            if (gameState.CurrentQuestionIndex >= 4)
            {
                response.Say("I didn't hear your answer in time.  That was the last question.  Lets see how you did.");
                response.Redirect(Url.ActionAbsolute("CalculateResults"), "GET");
            }
            else
            {
                gameState.CurrentQuestionIndex++;

                response.Say("I didn't hear your answer in time.  Lets try the next question.");
                response.Redirect(Url.ActionAbsolute("ReadQuestion"), "GET");
            }

            gameState.Save();
            return TwiML(response); 
        }

        public ActionResult CaptureAnswer(string CallSid, int Digits)
        {
            var gameState = QuizShowState.Load(CallSid);

            var currentQuestion = gameState.Questions[gameState.CurrentQuestionIndex];
            var orderedAnswers = currentQuestion.PossibleAnswers.OrderBy(a => a.Order).ToList();
            var selectedAnswer = orderedAnswers[Digits];

            var response = new TwilioResponse();

            if (selectedAnswer.IsCorrect)
            {
                gameState.CorrectAnswerCount++;

                response.Say("Correct! . Well done. ");

                if (gameState.CurrentQuestionIndex >= 4)
                {

                    response.Say("That was the last question.  Lets see how you did.");
                    response.Redirect(Url.ActionAbsolute("CalculateResults"), "GET");
                }
                else
                {
                    gameState.CurrentQuestionIndex++;

                    response.Say("Lets try the next question.");
                    response.Redirect(Url.ActionAbsolute("ReadQuestion"), "GET");
                }
            }
            else
            {
                response.Say("Incorrect! . ");

                if (gameState.CurrentQuestionIndex >= 4)
                {

                    response.Say("That was the last question.  Lets see how you did.");
                    response.Redirect(Url.ActionAbsolute("CalculateResults"), "GET");
                }
                else
                {
                    gameState.CurrentQuestionIndex++;

                    response.Say("Lets try the next question.");
                    response.Redirect(Url.ActionAbsolute("ReadQuestion"), "GET");
                }
            }

            gameState.Save();

            return TwiML(response);
        }

        public ActionResult CalculateResults(string CallSid)
        {
            var gameState = QuizShowState.Load(CallSid);

            var response = new TwilioResponse();

            switch(gameState.CorrectAnswerCount)
            {
                case 0:
                    response.Say("Woah.  You got every question wrong.  Maybe trivia is not for you.");
                    break;
                case 1:
                    response.Say("You got one out of five right.  ");
                    break;
                case 2:
                    response.Say("Better luck next time.  You answered two out of five correctly.");
                    break;
                case 3:
                    response.Say("Not bad.  You answered three out of five correctly.  Thats pretty average.");
                    break;
                case 4:
                    response.Say("Well done!  Four out of five correct is excellent.");
                    break;
                case 5:
                    response.Say("Amazing!  You got all five questions right.  Your brain must be huge!");
                    break;            
            }

            response.Redirect(Url.ActionAbsolute("DetermineWaitExperience", "Phone"), "GET");

            return TwiML(response);
        }

    }
}
