using Tyuiu.IlkaevNR.Sprint1.Task5.V3.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DatraServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 333;
            var res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }
    }
}
