using DSAguides.Interface.Nodes;

namespace DSAguides.Models.DataStructures.Array
{
    public class ArrayNodeFactory : INodeFactory
    {
        public ArrayNodeFactory() { }

        public INode[] CreateNodes(int count)
        {
            var nodes = new INode[count];

            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = CreateNode(i);
            }

            return nodes;
        }

        public INode[] CreateNodes(int[] elements)
        {
            var nodes = new INode[elements.Length];

            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = CreateNode(i, elements[i]);
            }

            return nodes;
        }

        public INode CreateNode(int index, int? element = null)
        {
            return new ArrayNode(index, element);

        }
    }
}
