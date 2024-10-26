using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyCalcLib.Test
{
    [TestClass]
    public class MyCalcTest
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange

            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();

            int actual = c.Sum(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Min_10and20_30returned()
        {
            int x = 50;
            int y = 20;
            int expected2 = 30;

            MyCalc c = new MyCalc();

            int actual2 = c.Min(x, y);

            Assert.AreEqual(expected2, actual2);
        }
    }
}
