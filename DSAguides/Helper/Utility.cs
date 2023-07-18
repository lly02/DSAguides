using DSAguides.Interface.Interface;
using DSAguides.Models.DataStructures.Array;

namespace DSAguides.Helper
{
    public static class Utility
    {
        public static int[] StringToIntArray(string s)
        {
            var result = new List<int>();

            foreach (string str in s.Split(','))
            {
                result.Add(int.Parse(str));
            }

            return result.ToArray();
        }

        public static INode[] AppendNode(INode[] nodes, int append)
        {
            var intList = new List<int>();

            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Element is null) break;
                intList.Add((int)nodes[i].Element!);
            }
            intList.Add(append);
            int[] intArray = intList.ToArray();

            return new ArrayNodeFactory().CreateNodes(intArray);
        }

        public static INode[] RemoveIndex(INode[] nodes, int removeIndex)
        {
            var intList = new List<INode>();

            for (int i = 0; i < nodes.Length; i++)
            {
                if (i == removeIndex) continue;
                intList.Add(nodes[i]);
            }

            return intList.ToArray();
        }
    }
}
