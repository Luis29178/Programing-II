using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void BlackjackHandTest()
        {
            Hand hand = new BlackjackHand();
            hand.AddCard();

            Assert.Fail();
        }

        [TestMethod()]
        public void BlackjackHandTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCardTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawTest()
        {
            Assert.Fail();
        }
    }
}