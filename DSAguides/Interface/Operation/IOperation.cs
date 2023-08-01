using DSAguides.Interface.Nodes;
using System.ComponentModel;

namespace DSAguides.Interface.Operation
{
    public interface IOperation
    {
        public INode[]? EndState { get; set; }
        public void NextFrame();
    }
}
