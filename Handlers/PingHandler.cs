using MediatR;
using System.Threading;
using escola_api.Requests;
using System.Threading.Tasks;

namespace escola_api.Handlers
{
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping ping, CancellationToken token)
        {
            return Task.FromResult("Pong do Handler !");
        }
    }
}