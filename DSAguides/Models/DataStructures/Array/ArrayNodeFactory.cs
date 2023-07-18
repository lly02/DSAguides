using DSAguides.Models.Shared.Nodes;
using DSAguides.Models.Shared.Nodes.Interface;

namespace DSAguides.Models.DataStructures.Array
{
    public class ArrayNodeFactory : NodeFactory
    {
        public ArrayNodeFactory() { }

        public override INode[] CreateNodes(int count)
        {
            var nodes = new INode[count];

            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new ArrayNode(i);
            }

            return nodes;
        }
    }
}
