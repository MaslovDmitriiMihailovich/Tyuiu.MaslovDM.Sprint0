using Tyuiu.MaslovDM.Sprint0.Task6.V0.Lib;

namespace Tyuiu.MaslovDM.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = new DataServiceTest.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
    }
}
