using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.PimenovaTS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 13;
            DataService ds = new DataService();
            int res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            Assert.AreEqual(6, res);
        }
    }
}
