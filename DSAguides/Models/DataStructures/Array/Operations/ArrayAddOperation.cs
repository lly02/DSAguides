using DSAguides.Interface.Nodes;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayAddOperation : ArrayOperation
    {
        private ArrayClearOperation? _clearOperation;
        private int _addPosition = -1;

        public ArrayAddOperation()
            : base() { }

        public ArrayAddOperation(Pages.DataStructures.Array page, INode[] endState)
            : base(page, endState)
        {
        }

        public override void NextFrame()
        {
            if (_addPosition == -1)
            {
                for (int i = 0; i < EndState!.Length; i++)
                {
                    if (Page!.Nodes![i].Element == null)
                    {
                        _addPosition = i;
                        break;
                    }
                }

                Done = _addPosition == -1 ? true : false;
            }

            if (Done) return;

            Page!.Nodes![_addPosition].Element = EndState![_addPosition].Element;
            Page.Information = $"Adding element {EndState[_addPosition].ElementToString} at index {EndState[_addPosition].Index}.";

            _addPosition++;
            Done = _addPosition >= EndState.Length ? true : false;
        }
    }
}
