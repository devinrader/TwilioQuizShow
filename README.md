Twilio Quiz Show
==============

Twilio Quiz Show is a sample that demostrates how to use the Twilio [&lt;Gather&gt;](http://www.twilio.com/docs/api/twiml/gather) verb inside of TwiML responses returned as part of a queue wait experience.  The sample includes a sample IVR which adds a caller to a [Queue](http://www.twilio.com/docs/api/twiml/enqueue) and allows them to play a simple trivia game while they wait.  Additionally the sample includes a test webpage that allows ou to call the queue.

Prerequisites
--------------
In order to run this sample you will need to ensure you have the following prerequisites installed:

* Visual Studio 2012 or later
* ASP.NET MVC 4 or later

Configuration
--------------
This sample comes with a single project that you need to configure and deploy. Lets walk through whats there and how to get it running. To get started:

* If you don't already have one, [create an Twilio account](https://www.twilio.com/try-twilio).  You will need at least one Twilio phone number.
* Make sure you have the prequisites listed above installed

Next, grab the latest source code and open the solution in Visual Studio.  Before you run the project, there are several configuration values that you need to change.  You can find all of these values in the AppSettings.config file

* TokenGeneratorUrl - The sample needs a Twilio Client token to power the browser phone.  By default the project expects to download a token from a public URL which you can set using this key.
* TargetPhoneNumber - This is the phone number that the serves as the entry point into the Quiz Show IVR.
* CallerIdPhoneNumber - This is the phone number used as the Twilio Clients caller ID.

Once you've updated the configuration settings, deploy the TwilioQuizShow project to your web host.

Finally, point the Voice URL for your Twilio phone number at _http://[yourhost]/Phone/EnqueueCaller_

You should not be able to load the default project page in a browser and call the Quiz Show IVR.

More Info
-------------
The full Queue documentation is available here: http://www.twilio.com/docs/api/twiml/queue and http://www.twilio.com/docs/api/rest/queue

Built for explanation & demo purposes, February 2013.
