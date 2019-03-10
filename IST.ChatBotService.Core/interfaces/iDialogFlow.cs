using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IST.ChatBotService.Core.response;
using IST.ChatBotService.Core.request;
namespace IST.ChatBotService.Core.interfaces
{
    public interface iDialogFlow
    {
        Task<DialogFlowResponse> SendMessage(DialogFlowRequest request);
    }
}
