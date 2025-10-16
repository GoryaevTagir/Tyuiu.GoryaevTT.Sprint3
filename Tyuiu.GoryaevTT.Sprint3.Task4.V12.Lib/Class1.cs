using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GoryaevTT.Sprint3.Task4.V12.Lib
{
    public class Class1 : ISprint3Task4V12
    {
        public double Calculate(int startValue, int stopValue)
        {
            double ans = 1;
            if (startValue >= -5 && startValue <= 5)
            {
                for (int i = startValue; i < stopValue; i++)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans *= i / (i + Math.Sin(i)) + 2.5;
                    }
                }
            }
            return Math.Round(ans, 2);
        }    
    }
}
