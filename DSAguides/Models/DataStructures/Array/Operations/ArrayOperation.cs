using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public abstract class ArrayOperation
    {
        private INode[] _currentState;
        private INode[] _endState;

        public INode[] CurrentState
        {
            get => _currentState;
            set => _currentState = value;
        }
        public INode[] EndState
        {
            get => _endState;
            set => _endState = value;
        }
        public bool Done { get; set; } = false;

        public ArrayOperation(INode[] current, INode[] nodes)
        {
            _currentState = current;
            _endState = nodes;
        }

        public abstract INode[] NextFrame();
    }
}
