using MediatR;
using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService;

namespace TestCaseElevator.Services.EventHandler
{
    public class DownActionQuery : IRequestHandler<DownActionRequest, DownActionResponse>
    {
        readonly IElevatorOutdoorController _controller;
        public DownActionQuery(IElevatorOutdoorController controller) { _controller = controller; }

        public async Task<DownActionResponse> Handle(DownActionRequest request, CancellationToken cancellationToken)
        {
            DownActionResponse res;
            try
            {
                var r = _controller.downButton(request.floorRequested);
                res = new DownActionResponse() { listFloor = (List<int>)r };
            }
            catch (Exception ex)
            {
                res = new DownActionResponse();
                Console.WriteLine(ex.ToString());
            }
            return res;
        }
    }
}
