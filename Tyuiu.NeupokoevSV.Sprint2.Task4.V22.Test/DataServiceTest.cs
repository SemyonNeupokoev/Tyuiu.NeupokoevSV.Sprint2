using Tyuiu.NeupokoevSV.Sprint2.Task4.V22.Lib;
namespace Tyuiu.NeupokoevSV.Sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
