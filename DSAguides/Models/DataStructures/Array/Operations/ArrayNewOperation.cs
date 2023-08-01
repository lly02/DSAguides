using DSAguides.Interface.Nodes;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayNewOperation : ArrayOperation
    {
        //private ArrayClearOperation _clearOperation;
        private ArrayAddOperation? _addOperation;
        private bool _newArrayCreated = false;

        public ArrayNewOperation()
            : base() { }

        public ArrayNewOperation(Pages.DataStructures.Array page, INode[] endState)
            : base(page, endState)
        {
            //_clearOperation = new ArrayClearOperation(
            //    page,
            //    new ArrayNodeFactory().CreateNodes(10));
        }

        public override void NextFrame()
        {
            if (!_newArrayCreated)
            {
                Page.Nodes = new ArrayNodeFactory().CreateNodes(EndState!.Length);
                Page.Information = $"Creating an array of size {EndState.Length}.";
                _newArrayCreated = true;
                return;
            }

            if (_addOperation is null) _addOperation = new ArrayAddOperation(Page!, EndState!);

            _addOperation.NextFrame();
            Done = _addOperation.Done ? true : false;
        }
    }
}
