using System;
namespace IST.ChatBotService.Core.request
{
    public class DialogFlowRequest
    {
        public string Query { get; set; }
        public string Lang { get; set; }
        public string SessionId { get; set; }
    }
}
