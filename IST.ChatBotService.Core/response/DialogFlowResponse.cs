using System;
using System.Collections.Generic;
namespace IST.ChatBotService.Core.response
{
    public class DialogFlowResponse

    {
        public Result result { get; set; }
        public string SessionId { get; set; }

    }

    public class Result
    {
        public Fulfillment Fulfillment { get; set; }
    }

    public class Fulfillment
    {
        public string Speech { get; set; } 
        public IList<Messages> Messages { get; set; } 
    }
    public class Messages
    {
        public string Type { get; set; } 
        public string Speech { get; set; }
    }
}
