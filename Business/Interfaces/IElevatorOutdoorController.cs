namespace TestCaseElevator.Business.Interfaces
{
    public interface IElevatorOutdoorController
    {
        int callButton(int floorRequested, int currentFloor);
        IEnumerable<int> downButton(int floorRequested);
        IEnumerable<int> upButton(int floorRequested);
    }
}
