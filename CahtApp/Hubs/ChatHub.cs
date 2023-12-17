using CahtApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace CahtApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
