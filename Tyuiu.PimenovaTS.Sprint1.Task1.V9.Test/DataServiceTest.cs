using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PimenovaTS.Sprint1.Task1.V9.Lib;

namespace Tyuiu.PimenovaTS.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);

        }
    }
}
