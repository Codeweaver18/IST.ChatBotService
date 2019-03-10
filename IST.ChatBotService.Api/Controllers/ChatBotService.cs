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
using IST.ChatBotService.Core.response;
using IST.ChatBotService.Core.request;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IST.ChatBotService.Api.Controllers
{
    [Route("api/ChatBotService")]
    public class ChatBotServiceController : TwilioController
    {
        private  readonly IIDialogFlow _DialogFlow;

        public ChatBotServiceController(IIDialogFlow DialogFlow)
        {
            _DialogFlow = DialogFlow;
        }

        [HttpPost]
        [Route("whatsapp/Recieve")]
        public async Task<TwiMLResult> Index(SmsRequest incomingMessage)
        {
            var requestbody = incomingMessage.Body;
            var response = new MessagingResponse();

            //sending request to google dialog flow via implemented service.
            DialogFlowResponse result = await _DialogFlow.SendMessage(new DialogFlowRequest { SessionId = incomingMessage.From, Lang = "en", Query = incomingMessage.Body });

           if (result!=null)
            {
                response.Message(result.result.Fulfillment.Messages[1].ToString());
            }


            return TwiML(response);
        }

        [HttpPost]
        [Route("Dialog")]
        public async Task<string> Test([FromBody] string message)
        {
 
            //sending request to google dialog flow via implemented service.
            DialogFlowResponse result = await _DialogFlow.SendMessage(new DialogFlowRequest { SessionId = "08065958692", Lang = "en", Query = message});

            //
             var response = result.result.Fulfillment.Messages[2].ToString();

            return response;

        }

    }
}
