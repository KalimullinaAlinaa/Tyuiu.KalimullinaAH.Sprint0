using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KalimullinaAH.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        { 
        
            //область создания методов тестирования, методов из библиотеки
            var name = "Алина";
            var res = DataService.GetMessage(name);
            // Вызов класса Assert и метод AreEqual
            Assert.AreEqual("Привет,Алина",res);
        }
    }
}
