using Tyuiu.GoryaevTT.Sprint3.Task5.V18.Lib;

namespace Tyuiu.GoryaevTT.Sprint3.Task5.V18.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int a = 5;
            int b = 1;
            int c = 1;
            int e = 3;
            int f = 11;
            double res = ds.GetSumSumSeries(a, b, c, e, f);
            Assert.AreEqual(768.36, res);
        }
    }
}
