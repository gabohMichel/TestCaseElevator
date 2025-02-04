using static TestCaseElevator.Business.Enums.Enumerators;

namespace TestCaseElevator.Business.Operations
{
    public class Operator
    {
        public static List<int> floors = new List<int>() { 1, 2, 3, 4, 5 };
        public Func<int, int, int> getMovePosition = (nextFloor, currentFloor) => nextFloor - currentFloor;
        public Func<int, Direction, List<int>> listFloor = (int floor, Direction direction) => {
            if (direction.Equals(Direction.Up))
                return floors.Where(n => n > floor).ToList();
            else
                return floors.Where(n => n < floor).ToList();
        };
    }
}
