namespace DSAguides.Interface.Nodes
{
    public interface INode
    {
        int Index { get; set; }
        int? Element { get; set; }
        string ElementToString { get; }
    }
}
