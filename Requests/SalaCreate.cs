using MediatR;
using escola_api.Entities;

namespace escola_api.Requests
{
    public class SalaCreate : IRequest<Sala>
    {
        public string Nome { get; set; }
    }
}