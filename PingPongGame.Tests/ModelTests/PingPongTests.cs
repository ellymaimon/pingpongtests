using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGame;

namespace PingPongGame.Tests
{
    [TestClass]
    public class PingPongTests
    {
        [TestMethod]
        public void IsNotInteger_InputIsNotInteger_False()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(false, testPingPong.IsNotInteger("hello"));
        }

        [TestMethod]
        public void PingPongTest_IsDivisibleByThree_Ping()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping", testPingPong.PingPongTest(6));
        }

        [TestMethod]
        public void PingPongTest_IsDivisibleByFive_Pong()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("pong", testPingPong.PingPongTest(10));
        }

        [TestMethod]
        public void PingPongTest_IsDivisibleByBoth_PingPong()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping-pong", testPingPong.PingPongTest(15));
        }

        [TestMethod]
        public void PingPongTest_IsNotDivisibleByEither_4()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("4", testPingPong.PingPongTest(4));
        }

        [TestMethod]
        public void LengthListTest_ListLengthEqualsInput_True()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.LengthListTest(5));
        }

        [TestMethod]
        public void FirstLastElement_IsListIncreasingByOne_True()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.FirstLastElement(5));
        }
    }
}
