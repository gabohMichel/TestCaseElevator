namespace TestCaseElevator.Business.Validations
{
    public class Validator
    {
        public Func<int, int, bool> ValidationFloor = (int currentFloor, int nextFloor) => currentFloor == nextFloor || (nextFloor < 1 && nextFloor > 5) || (currentFloor < 1 && currentFloor > 5);
        public Func<int, bool> ValidationUpDown = (int floor) => !(floor == 2 || floor == 3 || floor == 4);
    }
}
