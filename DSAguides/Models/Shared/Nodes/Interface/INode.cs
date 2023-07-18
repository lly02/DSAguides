namespace DSAguides.Models.Shared.Nodes.Interface
{
    public interface INode
    {
        int Index { get; set;  }
        int? Element { get; set; }
        string ElementToString { get; }
    }
}
