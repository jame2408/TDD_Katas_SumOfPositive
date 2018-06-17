using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSumOfPositive
{
    [TestClass]
    public class TestSumOfPositive
    {
        [TestMethod]
        public void Input_One_Positive_Number_Array_1_Should_Be_1()
        {
            var sumOfPositive = new SumOfPositive();
            var sum = sumOfPositive.AddPositive(new[] { 1 });
            Assert.AreEqual(1, sum);
        }

        [TestMethod]
        public void Input_Two_Positive_Number_Array_1_3_Should_Be_4()
        {
            var sumOfPositive = new SumOfPositive();
            var sum = sumOfPositive.AddPositive(new[] { 1, 3 });
            Assert.AreEqual(4, sum);
        }
    }
}