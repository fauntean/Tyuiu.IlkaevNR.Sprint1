using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IlkaevNR.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(double x, double y)
        {
            double result = (x + y) / Math.Abs(x - 2);
            
            return Math.Round(result, 3); 
        }
    }
}
