using MediatR;
using escola_api.Entities;
using System.Collections.Generic;

namespace escola_api.Requests
{
    public class SalaAll : IRequest<List<Sala>>
    {
    }
}