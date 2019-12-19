using MediatR;
using System.Threading;
using escola_api.Entities;
using escola_api.Requests;
using System.Threading.Tasks;
using escola_api.Repositories;
using System.Collections.Generic;

namespace escola_api.Handlers
{
    public class SalaAllHandler : IRequestHandler<SalaAll, List<Sala>>
    {
        private readonly IRepository<Sala> _repository;
        public SalaAllHandler(IRepository<Sala> repository)
        {
            _repository = repository;
        }

        public Task<List<Sala>> Handle(SalaAll sala, CancellationToken token)
        {
            return Task.FromResult(_repository.All());
        }
    }
}