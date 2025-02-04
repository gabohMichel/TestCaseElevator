using MediatR;

namespace TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService
{
    public class CallElevatorRequest : IRequest<CallElevatorResponse>
    {
        public int floorRequest {  get; set; }
        public int currentFloor {  get; set; }
    }
}
