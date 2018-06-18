using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSumOfPositive
{
    [TestClass]
    public class TestSumOfPositive
    {
        [TestMethod]
        public void Input_One_Positive_Number_Array_1_Should_Be_1()
        {
            AddShouldBe(new[] { 1 }, 1);
        }

        [TestMethod]
        public void Input_Two_Positive_Number_Array_1_3_Should_Be_4()
        {
            AddShouldBe(new[] { 1, 3 }, 4);
        }

        [TestMethod]
        public void Input_Two_Positive_And_One_negative_Number_Array()
        {
            AddShouldBe(new[] { 1, 3, -2 }, 4);
        }

        [TestMethod]
        public void Input_Empty_Array()
        {
            AddShouldBe(new int[] { }, 0);
        }

        [TestMethod]
        public void Input_MaxInt_And_1_Should_Be_Overflow()
        {
            Action act = () => new SumOfPositive().AddPositive(new[] { int.MaxValue, 1 });

            act.Should().Throw<OverflowException>();
        }

        private static void AddShouldBe(int[] inputInts, int expected)
        {
            var sumOfPositive = new SumOfPositive();
            Assert.AreEqual(expected, sumOfPositive.AddPositive(inputInts));
        }
    }
}