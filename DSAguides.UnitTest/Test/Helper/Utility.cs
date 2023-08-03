using DSAguides.Interface.Nodes;
using DSAguides.Models.DataStructures.Array;

namespace DSAguides.UnitTest.Test.Helper
{
    [TestClass]
    public class Utility
    {
        [TestMethod]
        public void StringToIntArray_Pass()
        {
            string s = "1,2,3,4,5,6,7,8,9,10";
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = DSAguides.Helper.Utility.StringToIntArray(s);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void StringToIntArray_Fail_NotInteger()
        {
            string s = "1,2,3,4,5,ad";
            DSAguides.Helper.Utility.StringToIntArray(s);
        }


    }
}
