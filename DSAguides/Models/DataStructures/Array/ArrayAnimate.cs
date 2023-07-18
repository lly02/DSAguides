using DSAguides.Interface.Animation;
using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array
{
    public class ArrayAnimate
    {
        private INode[] _nodes;

        public ArrayAnimate(INode[] nodes) 
        {
            _nodes = nodes;
        }

        public void Insert(int index, int element)
        {
            _nodes[index].Element = element;
        }

        public void Remove(int index)
        {
            _nodes[index].Element = null;
        }
    }
}
