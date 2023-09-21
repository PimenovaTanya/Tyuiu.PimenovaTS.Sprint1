using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint1.Task3.V13.Lib;


namespace Tyuiu.PimenovaTS.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            double number = 123;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(number, res);
        }
    }
}
