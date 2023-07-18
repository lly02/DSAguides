using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayNewOperation : ArrayOperation
    {
        private ArrayClearOperation? _clearOperation;
        private ArrayAddOperation? _addOperation;

        public ArrayNewOperation(INode[] currentState, INode[] endState)
            : base(currentState, endState)
        {
            if (CurrentState.Length < EndState.Length)
            {
                _clearOperation = new ArrayClearOperation(
                new ArrayNodeFactory().CreateNodes(10),
                EndState);
            }
        }

        public override INode[] NextFrame()
        {
            if (_clearOperation != null && !_clearOperation.Done) return CurrentState = _clearOperation.NextFrame();
            if (_addOperation is null) _addOperation = new ArrayAddOperation(CurrentState, EndState);

            CurrentState = _addOperation.NextFrame();
            Done = _addOperation.Done ? true : false;

            return CurrentState;
        }
    }
}
