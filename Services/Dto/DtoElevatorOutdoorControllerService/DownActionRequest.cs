using MediatR;

namespace TestCaseElevator.Services.Dto.DtoElevatorOutdoorControllerService
{
    public class DownActionRequest : IRequest<DownActionResponse>
    {
        public int floorRequested { get; set; }
    }
}
