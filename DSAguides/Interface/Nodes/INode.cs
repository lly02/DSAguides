namespace DSAguides.Interface.Interface
{
    public interface INode
    {
        int Index { get; set; }
        int? Element { get; set; }
        string ElementToString { get; }
    }
}
