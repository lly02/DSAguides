using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayAddOperation : ArrayOperation
    {
        private ArrayClearOperation? _clearOperation;
        private int _addPosition = -1;

        public ArrayAddOperation(INode[] currentState, INode[] endState)
            : base(currentState, endState)
        {
        }

        public override INode[] NextFrame()
        {
            if (_addPosition == -1)
            {
                for (int i = 0; i < EndState.Length; i++)
                {
                    if (CurrentState[i].Element == null)
                    {
                        _addPosition = i;
                        break;
                    }
                }

                Done = _addPosition == -1 ? true : false;
            }

            if (Done) return CurrentState;

            CurrentState[_addPosition].Element = EndState[_addPosition].Element;
            _addPosition++;
            Done = _addPosition >= EndState.Length ? true : false;

            return CurrentState;
        }
    }
}
