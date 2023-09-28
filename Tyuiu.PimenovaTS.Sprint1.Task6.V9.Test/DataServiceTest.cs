using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint1.Task6.V9.Lib;


namespace Tyuiu.PimenovaTS.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strtest = "жизнь прекрасна";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(strtest);
            Assert.AreEqual("ьжизн апрекрасн", res);

        }
    }
}
