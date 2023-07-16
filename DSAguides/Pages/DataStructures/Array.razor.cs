using System.Runtime.InteropServices.JavaScript;

namespace DSAguides.Pages.DataStructures
{
    public partial class Array
    {
        [JSImport("newArray", "Array")]
        internal static partial void NewArrayJS(string s);

        [JSImport("addValue", "Array")]
        internal static partial void AddValueJS(string s);

        [JSImport("removeIndex", "Array")]
        internal static partial void RemoveIndexJS(string s);

        [JSImport("clear", "Array")]
        internal static partial void ClearJS();
    }
}
