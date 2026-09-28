using Tyuiu.IlkaevNR.Sprint1.Task6.V1.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            string value = "1";
            var res = ds.SymbolCode(value);
            Assert.AreEqual("49", res);
        }
    }
}
