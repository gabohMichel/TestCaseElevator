using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Business.Operations;
using TestCaseElevator.Business.Validations;

namespace TestCaseElevator.Business.Classes
{
    public class ElevatorIndoorController : IElevatorIndoorController
    {
        private readonly Validator _validator;
        private readonly Operator _operator;
        public ElevatorIndoorController(Validator validator, Operator op) 
        {
            _validator = validator;
            _operator = op;
        }
        public int moveElevator(int currentFloor, int nextFloor)
        {
            if (_validator.ValidationFloor(currentFloor, nextFloor))
                return 0;

            return _operator.getMovePosition(nextFloor, currentFloor);
        }
    }
}
