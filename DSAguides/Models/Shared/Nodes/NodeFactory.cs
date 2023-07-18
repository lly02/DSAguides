using DSAguides.Models.Shared.Nodes.Interface;

namespace DSAguides.Models.Shared.Nodes
{
    public abstract class NodeFactory
    {
        public NodeFactory() { }

        public abstract INode[] CreateNodes(int count);
    }
}
