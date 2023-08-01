using DSAguides.Interface.Operation;
using DSAguides.Interface.Nodes;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public abstract class ArrayOperation : IOperation
    {
        private Pages.DataStructures.Array? _page;
        private INode[]? _endState;

        public Pages.DataStructures.Array? Page
        {
            get => _page;
            set => _page = value;
        }
        public INode[]? EndState
        {
            get => _endState ?? null;
            set => _endState = value;
        }
        public bool Done { get; set; } = false;

        public ArrayOperation() { }

        public ArrayOperation(Pages.DataStructures.Array page, INode[] endState)
        {
            _page = page;
            _endState = endState;
        }

        public abstract void NextFrame();
    }
}
