using MediatR;
using System.Threading;
using escola_api.Entities;
using escola_api.Requests;
using System.Threading.Tasks;
using escola_api.Repositories;

namespace escola_api.Handlers
{
    public class SalaCreateHandler : IRequestHandler<SalaCreate, Sala>
    {
        private readonly IRepository<Sala> _repository;
        public SalaCreateHandler(IRepository<Sala> repository)
        {
            _repository = repository;
        }

        public Task<Sala> Handle(SalaCreate sala, CancellationToken token)
        {
            return Task.FromResult(_repository.Create(new Sala() { Nome = sala.Nome }));
        }
    }
}