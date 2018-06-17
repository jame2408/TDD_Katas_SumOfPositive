﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        private static void AddShouldBe(int[] inputInts, int expected)
        {
            var sumOfPositive = new SumOfPositive();
            Assert.AreEqual(expected, sumOfPositive.AddPositive(inputInts));
        }
    }
}