using Tyuiu.GoryaevTT.Sprint3.Task4.V12.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task4.V12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int x = -5;
            int y = 5;
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
        }
    }
}