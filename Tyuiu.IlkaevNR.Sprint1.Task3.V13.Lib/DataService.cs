using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IlkaevNR.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int n = (int)number;

            int d1 = n / 100;
            int d2 = (n / 10) % 10;
            int d3 = n % 10;

            double result = d1 * d2 * d3;

            return Math.Round(result, 3);
        }
    }
}
