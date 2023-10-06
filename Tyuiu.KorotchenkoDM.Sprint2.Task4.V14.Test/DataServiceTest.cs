using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint2.Task4.V14.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 2.25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3 * Math.PI;
            double y = Math.PI;
            double res = ds.Calculate(x, y);
            double wait = 0.187;
            Assert.AreEqual(wait, res);
        }
    }
}
