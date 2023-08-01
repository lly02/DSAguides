using DSAguides.Interface.Nodes;

namespace DSAguides.Models.DataStructures.Array
{
    public class ArrayNode : INode
    {
        private int _index;
        private int? _element;

        public int Index 
        { 
            get => _index;
            set => _index = value;
        }
        public int? Element
        {
            get => _element;
            set => _element = value;
        }

        public string ElementToString
        {
            get => _element == null ? "" : _element.ToString()!;
        }

        public ArrayNode(int index, int? element)
        {
            _index = index;
            _element = element;
        }
    }
}
