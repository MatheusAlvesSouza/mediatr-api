using MediatR;
using escola_api.Requests;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace escola_api.Controllers
{
    [Route("api/[controller]")]
    public class SalaController : Controller
    {
        IMediator _mediator;
        public SalaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Sala([FromBody] SalaCreate sala)
        {
            var result = await _mediator.Send(sala);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Salas(SalaAll salas)
        {
            var result = await _mediator.Send(salas);

            return Ok(result);
        }
    }
}