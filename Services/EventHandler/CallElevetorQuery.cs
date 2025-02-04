using MediatR;
using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService;

namespace TestCaseElevator.Services.EventHandler
{
    public class CallElevetorQuery : IRequestHandler<CallElevatorRequest, CallElevatorResponse>
    {
        readonly IElevatorOutdoorController _controller;
        public CallElevetorQuery(IElevatorOutdoorController controller) { _controller = controller; }

        public async Task<CallElevatorResponse> Handle(CallElevatorRequest request, CancellationToken cancellationToken)
        {
            CallElevatorResponse res;
            try
            {
                var r = _controller.callButton(request.floorRequest, request.currentFloor);
                res = new CallElevatorResponse() { result = r };
            }
            catch (Exception ex)
            {
                res = new CallElevatorResponse();
                Console.WriteLine(ex.ToString());
            }
            return res;
        }
    }
}
