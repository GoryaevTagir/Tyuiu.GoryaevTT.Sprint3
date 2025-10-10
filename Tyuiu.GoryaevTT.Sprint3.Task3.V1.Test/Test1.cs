using Tyuiu.GoryaevTT.Sprint3.Task3.V1.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string v = "have a nice time";
            char c = 'a';
            int res = ds.GetCharCount(v, c);
            Assert.AreEqual(2, res);
        }
    }
}
