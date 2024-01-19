using MediatR;

namespace SignalRApp.Signal
{
    internal class SendMessageCommand : IRequest<object>
    {
        public string Message { get; set; }
    }
}