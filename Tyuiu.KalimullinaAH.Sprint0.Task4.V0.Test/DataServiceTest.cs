using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KalimullinaAH.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubstractionlValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }

        public void CheckedMultiplicationlValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(5, 5));
        }
        public void CheckedDividionlValid()
        {
            Assert.AreEqual(3, DataService.Multiplication(9, 3));
        }
    }
}
