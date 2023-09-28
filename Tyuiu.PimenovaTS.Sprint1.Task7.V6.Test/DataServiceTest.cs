using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint1.Task7.V6.Lib;

namespace Tyuiu.PimenovaTS.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = -22;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
