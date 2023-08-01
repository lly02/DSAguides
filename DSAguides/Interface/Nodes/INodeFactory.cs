namespace DSAguides.Interface.Nodes
{
    public interface INodeFactory
    {
        public INode[] CreateNodes(int count);
        public INode[] CreateNodes(int[] elements);
        public INode CreateNode(int index, int? elements);
    }
}
