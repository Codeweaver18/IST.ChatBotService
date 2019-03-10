using System;
using System.Threading.Tasks;
using IST.ChatBotService.Core.interfaces;
using IST.ChatBotService.Core.request;
using IST.ChatBotService.Core.response;
using IST.ChatBotService.Core.utilities;


namespace IST.ChatBotService.Core.Services
{
    public class DialogFlowService:iDialogFlow
    {
        private readonly HttpWeaverClient _http;
        public DialogFlowService(HttpWeaverClient http)
        {
            _http = http;

        }

        public async Task<DialogFlowResponse> SendMessage(DialogFlowRequest request)
         {
            
            DialogFlowResponse response = new DialogFlowResponse();
            response = await _http.PostJSONAsync<DialogFlowResponse>("https://api.dialogflow.com/v1/query?v=20150910", headers:new DialogFlowHeader());

            return response;

        }

    }
}
