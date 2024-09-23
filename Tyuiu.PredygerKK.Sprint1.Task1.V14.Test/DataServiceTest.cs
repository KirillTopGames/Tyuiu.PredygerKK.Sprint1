using Tyuiu.PredygerKK.Sprint1.Task1.V14.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            int a = 10;
            int b = 18;
            int c = 36;
            Assert.AreEqual(5, DataService.Primer(a, b, c));
        }
    }
}