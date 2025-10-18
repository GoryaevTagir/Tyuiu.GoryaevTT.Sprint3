using Tyuiu.GoryaevTT.Sprint3.Task7.V11.Lib;
namespace Tyuiu.GoryaevTT.Sprint3.Task7.V11
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            double[] res = ds.GetMassFunction(-5, 5);
            int start = -5;
            for (int i = 0; i <= (res.Length - 1); i++)
            {
                Console.WriteLine($"{ Convert.ToString(start)}, { res[i]}");
                start++;
            }
        }
    }
}