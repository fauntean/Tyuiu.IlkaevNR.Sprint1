using Tyuiu.IlkaevNR.Sprint1.Task3.V13.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 333.0;
            var res  = ds.MultiplyOfDigits(x);
            Assert.AreEqual(27.0, res);
        }
    }
}
