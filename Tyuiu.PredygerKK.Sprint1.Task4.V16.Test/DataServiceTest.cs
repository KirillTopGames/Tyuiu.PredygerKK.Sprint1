using Tyuiu.PredygerKK.Sprint1.Task4.V16.Lib;

namespace Tyuiu.PredygerKK.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double x = 6;
            Assert.AreEqual(0.1, ds.Calculate(x));
           
        }
    }
}