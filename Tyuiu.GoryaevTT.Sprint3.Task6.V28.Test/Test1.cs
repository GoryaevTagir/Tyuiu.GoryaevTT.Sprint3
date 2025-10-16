using Tyuiu.GoryaevTT.Sprint3.Task6.V28.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task6.V28.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int a = 13;
            int b = 19;
            int res = ds.GetSumTheDivisors(a, b);
            Assert.AreEqual(15, res);
        }
    }
}
