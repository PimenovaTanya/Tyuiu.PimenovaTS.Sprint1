using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint1.Task4.V28.Lib;

namespace Tyuiu.PimenovaTS.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);

        }
    }
}
