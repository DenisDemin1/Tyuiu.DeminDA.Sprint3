using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint3.Task6.V6.Lib;
namespace Tyuiu.DeminDA.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 11;

            Assert.AreEqual(wait, res);


        }
    }
}
