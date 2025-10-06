using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GoryaevTT.Sprint3.Task1.V25.Lib
{
    public class Class1 : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double mul = 0;
            while (startValue <= stopValue)
            {
                mul *= (Math.Pow(value, startValue) - 0.25) * Math.Cos(5);
                startValue++;
            }
            return mul;
        }
    }
}
