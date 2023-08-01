    namespace DSAguides.UnitTest.Test.Helper
{
    [TestClass]
    public class Utility
    {
        [TestMethod]
        public void StringToIntArray_Correct_String_Length_10()
        {
            string S = "1,2,3,4,5,6,7,8,9,10";
            var Expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] Actual = DSAguides.Helper.Utility.StringToIntArray(S);

            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void StringToIntArray_Wrong()
        {
            string s = "1,2,3,4,sdf";

            Assert.ThrowsException<FormatException>(() => DSAguides.Helper.Utility.StringToIntArray(s));
        }
    }
}
