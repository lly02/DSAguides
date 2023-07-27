using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public abstract class ArrayOperation
    {
        private Pages.DataStructures.Array _page;
        private INode[] _endState;

        public Pages.DataStructures.Array Page => _page;
        public INode[] EndState
        {
            get => _endState;
            set => _endState = value;
        }
        public bool Done { get; set; } = false;

        public ArrayOperation(Pages.DataStructures.Array page, INode[] endState)
        {
            _page = page;
            _endState = endState;
        }

        public abstract void NextFrame();
    }
}
