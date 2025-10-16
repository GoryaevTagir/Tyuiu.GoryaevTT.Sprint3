using Tyuiu.GoryaevTT.Sprint3.Task4.V12.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int x = -5;
            int y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(17.155, res);
        }
    }
}
