using Tyuiu.PredygerKK.Sprint1.Task2.V5.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int x = 2;
            Assert.AreEqual(16, 4*x*x);
        }
    }
}