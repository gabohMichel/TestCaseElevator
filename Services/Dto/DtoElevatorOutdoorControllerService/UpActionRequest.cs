using MediatR;

namespace TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService
{
    public class UpActionRequest : IRequest<UpActionResponse>
    {
        public int floorRequested {  get; set; }
    }
}
