using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPongGame;

namespace PingPongGame.Tests
{
    [TestClass]
    public class PingPongTests
    {
        [TestMethod]
        public void IsInteger_InputIsNotInteger_False()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(false, testPingPong.IsInteger("hello"));
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
        public void PopulateRangeList_IsListPopulated_ListContent()
        {
            PingPong testPingPong = new PingPong();
            CollectionAssert.AreEqual(new List<int>(){1,2,3}, testPingPong.PopulateRangeList("3"));
        }

        [TestMethod]
        public void PopulateResultsList_CreatesFinishedList_ListContents()
        {
            PingPong testPingPong = new PingPong();
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("ping");
            list.Add("4");
            list.Add("pong");
            list.Add("ping");
            list.Add("7");
            list.Add("8");
            list.Add("ping");
            list.Add("pong");
            list.Add("11");
            list.Add("ping");
            list.Add("13");
            list.Add("14");
            list.Add("ping-pong");


            CollectionAssert.AreEqual(list, testPingPong.PopulateResultsList("15"));
        }
    }
}
