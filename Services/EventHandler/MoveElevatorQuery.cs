using MediatR;
using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Services.Dto.DtoElevatorIndoorControllerService;

namespace TestCaseElevator.Services.EventHandler
{
    public class MoveElevatorQuery : IRequestHandler<MoveElevatorRequest, MoveElevatorResponse>
    {
        readonly IElevatorIndoorController _controller;
		public MoveElevatorQuery(IElevatorIndoorController controller) { _controller = controller; }
        public async Task<MoveElevatorResponse> Handle(MoveElevatorRequest request, CancellationToken cancellationToken)
        {
			MoveElevatorResponse res;
			try
			{
				var r = _controller.moveElevator(request.currentFloor, request.nextFloor);
				res = new MoveElevatorResponse() { result = r };
			}
			catch (Exception ex)
			{
				res = new MoveElevatorResponse();
                Console.WriteLine(ex.ToString());
			}
			return res;
        }
    }
}
