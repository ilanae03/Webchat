using Microsoft.AspNetCore.SignalR;
using System.Collections.Specialized;
using System.Globalization;

namespace webchat
{
    public class MyHub : Hub
    {
        public async Task EnviarMensagem(string mensagem)
        {
            await Clients.All.SendAsync("ReceberMensagem", mensagem);
        }
    }
}
