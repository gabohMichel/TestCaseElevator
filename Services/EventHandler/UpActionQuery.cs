using MediatR;
using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService;

namespace TestCaseElevator.Services.EventHandler
{
    public class UpActionQuery : IRequestHandler<UpActionRequest, UpActionResponse>
    {
        readonly IElevatorOutdoorController _controller;
        public UpActionQuery(IElevatorOutdoorController controller) { _controller = controller; }

        public async Task<UpActionResponse> Handle(UpActionRequest request, CancellationToken cancellationToken)
        {
            UpActionResponse res;
            try
            {
                var r = _controller.upButton(request.floorRequested);
                res = new UpActionResponse() { listFloor = (List<int>)r };
            }
            catch (Exception ex)
            {
                res = new UpActionResponse();
                Console.WriteLine(ex.ToString());
            }
            return res;
        }
    }
}
