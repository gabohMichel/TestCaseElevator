using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Business.Operations;
using TestCaseElevator.Business.Validations;
using static TestCaseElevator.Business.Enums.Enumerators;

namespace TestCaseElevator.Business.Classes
{
    public class ElevatorOutdoorController : IElevatorOutdoorController
    {
        private readonly Validator _validator;
        private readonly Operator _operator;
        public ElevatorOutdoorController(Validator validator, Operator op)
        {
            _validator = validator;
            _operator = op;
        }
        public int callButton(int floorRequested, int currentFloor)
        {
            if (_validator.ValidationFloor(currentFloor, floorRequested))
                return 0;

            return _operator.getMovePosition(floorRequested, currentFloor);
        }
        public IEnumerable<int> downButton(int floorRequested)
        {
            if(_validator.ValidationUpDown(floorRequested))
                return new List<int>();

            return _operator.listFloor(floorRequested, Direction.Down);
        }
        public IEnumerable<int> upButton(int floorRequested)
        {
            if (_validator.ValidationUpDown(floorRequested))
                return new List<int>();

            return _operator.listFloor(floorRequested, Direction.Up);
        }
    }
}
