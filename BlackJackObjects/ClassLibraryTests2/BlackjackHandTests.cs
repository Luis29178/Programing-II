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
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void BlackjackHandTest1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand hand = new BlackjackHand();
            hand.AddCard(Factory.CreateBlackjackCard(CardFace.ace, CardSuit.Spades));
            hand.AddCard(Factory.CreateBlackjackCard(CardFace.eight, CardSuit.Spades));
            Assert.AreEqual(19, hand.Score);
            hand.AddCard(Factory.CreateBlackjackCard(CardFace.ten, CardSuit.Spades));
            Assert.AreEqual(19, hand.Score);
        }

        [TestMethod()]
        public void DrawTest()
        {
            Assert.IsTrue(true);
        }
    }
}