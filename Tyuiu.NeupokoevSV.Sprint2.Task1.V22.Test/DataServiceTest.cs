using Tyuiu.NeupokoevSV.Sprint2.Task1.V22;
using Tyuiu.NeupokoevSV.Sprint2.Task1.V22.Lib;

namespace Tyuiu.NeupokoevSV.Sprint2.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = new bool[6];
            bool[] wait = new bool[6] { true, true, true, false, false, false };
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
