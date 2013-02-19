using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Mvc;
using TwilioQuizShow.Models;

namespace TwilioQuizShow.Controllers
{
    public class BasicWaitController : TwilioController
    {
        //
        // GET: /BasicWait/

        public ActionResult BasicWaitExperienceRedirect(string CallSid)
        {
            var gameState = QuizShowState.Load(CallSid);

            if (gameState != null)
            {
                return RedirectToAction("LeaveGameExperience");
            }

            return RedirectToAction("BasicWaitExperience");
        }

        public ActionResult LeaveGameExperience()
        {
            var response = new TwilioResponse();
            response.Say("Thanks for playing a game.");
            response.Redirect(Url.ActionAbsolute("BasicWaitExperience"));

            return TwiML(response);
        }

        public ActionResult BasicWaitExperience()
        {
            var response = new TwilioResponse();
            response.Play(Url.ContentAbsolute("~/Content/Audio/Basic/Music.mp3"));

            return TwiML(response);
        }

    }
}