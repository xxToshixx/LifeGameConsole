using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifeGameConsole;


namespace LifeGameTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            Board b = new Board();
            int x0y0 = 1;
            int x4y3 = 4;
            int x9y0 = 3;
            int x0y9 = 0;
            int x9y9 = 3;
            int x0y1 = 0;

            Assert.AreEqual(x0y0, b.NumNeibors(0, 0), "0,0 is not right");
            Assert.AreEqual(x4y3, b.NumNeibors(4, 3), "4,3 is not right");
            Assert.AreEqual(x9y0, b.NumNeibors(9, 0), "9,0 is not right");
            Assert.AreEqual(x0y9, b.NumNeibors(0, 9), "0,9 is not right"); 
            Assert.AreEqual(x9y9, b.NumNeibors(9, 9), "9,9 is not right");
            Assert.AreEqual(x0y1, b.NumNeibors(0, 1), "0,1 is not right");
            //Assert.AreEqual(x0y0, 9, "0,0 is not right");
            
        }
    }
}
