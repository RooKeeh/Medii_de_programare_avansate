using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Moldovan_Andrei_Lab1.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", Context.User.Identity.Name, message);
        }
    }
}