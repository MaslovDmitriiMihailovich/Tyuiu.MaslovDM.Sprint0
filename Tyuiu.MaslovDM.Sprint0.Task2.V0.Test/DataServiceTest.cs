using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MaslovDM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MaslovDM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Дима";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Дима", res);
        }
    }
}
