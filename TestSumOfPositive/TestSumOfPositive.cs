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
    }
}