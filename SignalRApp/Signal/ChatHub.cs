using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace SignalRApp.Signal
{
    public class ChatHub(IMediator mediator) : Hub
    {
        private readonly IMediator _mediator = mediator;
        public async Task SendMessage(string message)
        {
            var result = await _mediator.Send(new SendMessageCommand { Message = message });
            await Clients.All.SendAsync("ReceiveMessage", result);
            // await Clients.All.SendAsync("ReceiveMessage",message);
        }

        public void Send(string message)
        {
            Clients.All.SendAsync("Send", message);
        }



    }
}
