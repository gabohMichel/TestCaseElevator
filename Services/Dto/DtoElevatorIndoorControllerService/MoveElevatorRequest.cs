using MediatR;

namespace TestCaseElevator.Services.Dto.DtoElevatorIndoorControllerService
{
    public class MoveElevatorRequest : IRequest<MoveElevatorResponse>
    {
        public int currentFloor { get; set; }
        public int nextFloor { get; set; }
    }
}
