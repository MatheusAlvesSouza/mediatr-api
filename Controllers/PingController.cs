using MediatR;
using escola_api.Requests;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace escola_api.Controllers
{
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        IMediator _mediator;
        public PingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Ping()
        {
            var result = await _mediator.Send(new Ping());

            return Ok(result);
        }
    }
}