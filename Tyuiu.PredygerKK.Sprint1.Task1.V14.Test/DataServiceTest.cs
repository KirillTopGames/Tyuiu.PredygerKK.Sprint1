using Tyuiu.PredygerKK.Sprint1.Task1.V14.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            double a, b, c;
            a = 2;
            b = 1;
            c = 1;
            Assert.AreEqual(3, DataService.Primer(a, b, c));
        }
    }
}