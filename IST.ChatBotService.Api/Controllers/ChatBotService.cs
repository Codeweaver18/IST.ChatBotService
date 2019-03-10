using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.TwiML;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using IST.ChatBotService.Core.interfaces;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IST.ChatBotService.Api.Controllers
{
    [Route("api/ChatBotService")]
    public class ChatBotServiceController : TwilioController
    {
        //private  iDialogFlow<ChatBotServiceController> _DialogFlow;

        //public ChatBotServiceController(iDialogFlow<ChatBotServiceController> DialogFlow)
        //{
        //    _DialogFlow = DialogFlow;
        //}

        [HttpPost]
        [Route("whatsapp/Recieve")]
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            var requestbody = incomingMessage.Body;
            var response = new MessagingResponse();

           //send Message to Dialog flwo


            return TwiML(response);
        }

    }
}
