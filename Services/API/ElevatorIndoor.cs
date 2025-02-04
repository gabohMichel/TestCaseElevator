using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestCaseElevator.Services.Dto.DtoElevatorIndoorControllerService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestCaseElevator.Services.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorIndoor : ControllerBase
    {
        private IMediator _mediator;
        public ElevatorIndoor(IMediator mediator) { _mediator = mediator; }
        [HttpPost("MoveElevator")]
        public async Task<MoveElevatorResponse> MoveElevator(MoveElevatorRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
