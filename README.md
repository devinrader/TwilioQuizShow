Twilio Quiz Show
==============

Twilio Quiz Show is a sample that demostrates how to use the Twilio [<Gather>]() verb inside of TwiML responses returned as part of a queue wait experience.  The sample includes a sample IVR which adds a caller to a [Queue]() and allows them to play a simple trivia game while they wait.  Additionally the sample includes a test webpage that allows ou to call the queue.

Prerequisites
--------------
In order to run this sample you will need to ensure you have the following prerequisites installed:

Visual Studio 2012 or later
ASP.NET MVC 4 or later

Configuration
--------------
This sample comes with a single project that you need to configure and deploy. Lets walk through whats there and how to get it running. To get started:

* If you don't already have one, create an Twilio account
* Make sure you have the prequisites listed above installed

Next, grab the latest source code and open the solution in Visual Studio.  Before you run the project, you will need to configure how it generates a Twilio Client token.  By default the project expects to download a token from a public URL.  You can configure this URL by changing the value of the TwilioGeneratorUrl configuration key which is located in the AppSettings.config file:

<add key="TokenGeneratorUrl" value="[YOUR_GENERATOR_TOKEN]"/>

Once you've updated the settings, deploy the TwilioQuizShow project to your web host.



More Info
-------------
The full Queue documentation is available here: http://www.twilio.com/docs/api/twiml/queue and http://www.twilio.com/docs/api/rest/queue

Built for explanation & demo purposes, September 2012.
