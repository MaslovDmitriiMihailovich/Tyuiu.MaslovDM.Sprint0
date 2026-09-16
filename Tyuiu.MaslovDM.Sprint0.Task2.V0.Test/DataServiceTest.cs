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
            var name = "Дима";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Дима", res);
        }
    }
}
