using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IlkaevNR.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            
            int code = (int)value[0];

            return Convert.ToString(code);
        }
    }
}
