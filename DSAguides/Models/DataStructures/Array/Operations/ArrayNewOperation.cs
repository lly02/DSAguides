using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayNewOperation : ArrayOperation
    {
        private ArrayClearOperation _clearOperation;
        private ArrayAddOperation? _addOperation;

        public ArrayNewOperation(INode[] currentState, INode[] endState)
            : base(currentState, endState)
        {
            _clearOperation = new ArrayClearOperation(
                CurrentState,
                new ArrayNodeFactory().CreateNodes(10));
        }

        public override INode[] NextFrame()
        {
            if (!_clearOperation.Done) return CurrentState = _clearOperation.NextFrame();
            if (_addOperation is null) _addOperation = new ArrayAddOperation(CurrentState, EndState);

            CurrentState = _addOperation.NextFrame();
            Done = _addOperation.Done ? true : false;

            return CurrentState;
        }
    }
}
