using Tyuiu.IlkaevNR.Sprint1.Task7.V29.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.099, res); 
        }
    }
}
