using Microsoft.AspNetCore.Mvc;
using MediatR;
using TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestCaseElevator.Services.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorOutdoor : ControllerBase
    {
        private IMediator _mediator;
        public ElevatorOutdoor(IMediator mediator) { _mediator = mediator; }
        [HttpPost("CallElevator")]
        public async Task<CallElevatorResponse> CallElevator(CallElevatorRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("UpElevator")]
        public async Task<UpActionResponse> UpElevator(UpActionRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("DownElevator")]
        public async Task<DownActionResponse> DownElevator(DownActionRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
