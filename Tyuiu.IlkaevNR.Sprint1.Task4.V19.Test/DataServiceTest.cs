using Tyuiu.IlkaevNR.Sprint1.Task4.V19.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5.0, res);
        }
    }
}
