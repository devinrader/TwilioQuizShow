using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.TwiML;
using Twilio.TwiML.Mvc;
using TwilioQuizShow.Models;

namespace TwilioQuizShow.Controllers
{
    public class PhoneController : TwilioController
    {
        //
        // GET: /Phone/

        public ActionResult ConnectToFirstQueueMember()
        {
            var response = new TwilioResponse();
            response.DialQueue("CustomerServiceQueue", null);

            return TwiML(response);
        }


        public ActionResult EnqueueCaller(string callsid)
        {
            QueueState.CreateAndSave(callsid);

            var response = new TwilioResponse();
            response.Say("Adding you to the queue");
            response.Enqueue("CustomerServiceQueue", new 
            {
                action=Url.ActionAbsolute("LeaveQueue"),
                waitUrl=Url.ActionAbsolute("DetermineWaitExperience") 
            });

            return TwiML(response);
        }

        public ActionResult LeaveQueue(string CallSid, string QueueResult)
        {
            if (QueueResult == "bridged")
            {
                var state = QueueState.Load(CallSid);

                var response = new TwilioResponse();

                if (state.PlayQuizShow == true)
                {
                    response.Play(""); //end of game tone
                    response.Say("Thanks for playing our game");
                }

                response.Say("a representative is now available.  Hold on while we connect you.");

                return TwiML(response);
            }

            return new EmptyResult();
        }
        
        public ActionResult DetermineWaitExperience(string callsid, int QueuePosition, int CurrentQueueSize, int AvgQueueTime)
        {
            var state = QueueState.Load(callsid);

            // I'm just faking some metrics here that help me determine if 
            // the caller should be given the option to play a game.
            // Normally I'd be using the values passed from Twilio.

            var waitTime = 400;// AvgQueueTime;
            var memberPosition = 10; // QueuePosition;

            if (state.PlayQuizShow && waitTime > 300 && memberPosition > 5)
            {
                state.PlayQuizShow = true;
                state.Save();

                return RedirectToAction("QuizShowInvitationRedirect", "QuizShow", new { CallSid = callsid });
            }
            else
            {
                state.PlayQuizShow = false;
                state.Save();

                return RedirectToAction("BasicWaitExperienceRedirect", "BasicWait", new { CallSid = callsid });
            }
        }

    }
}
