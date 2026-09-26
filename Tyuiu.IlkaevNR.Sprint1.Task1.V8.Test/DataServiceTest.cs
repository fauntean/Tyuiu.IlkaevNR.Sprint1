using Tyuiu.IlkaevNR.Sprint1.Task1.V8.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = 2.0;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(1.5707963267948966, res);
        }
    }
}
