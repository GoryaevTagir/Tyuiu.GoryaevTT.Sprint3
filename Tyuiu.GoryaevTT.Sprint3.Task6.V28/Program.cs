using Tyuiu.GoryaevTT.Sprint3.Task6.V28.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task6.V28
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int a = 13;
            int b = 19;
            int res = ds.GetSumTheDivisors(a, b);
            Console.WriteLine(res);
        }
    }
}