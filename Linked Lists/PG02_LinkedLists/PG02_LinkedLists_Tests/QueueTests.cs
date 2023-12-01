using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG02_LinkedLists;

namespace PG02_LinkedLists_Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void EnqueueDequeueTest()
        {
            int[] testValues = new int[5] { 10, 20, 30, 40, 50 };
            PG2Queue<int> testQueue = new PG2Queue<int>();

            foreach (var testValue in testValues)
            {
                testQueue.Enqueue(testValue);
            }
            for (int i = 0; i < testValues.Length; i++)
            {
                int itemPopped = testQueue.Dequeue();
                Assert.AreEqual(testValues[i], itemPopped);
            }
        }

        [TestMethod]
        public void DequeueExceptionTest()
        {

            PG2Queue<int> testQueue = new PG2Queue<int>();

            Assert.ThrowsException<InvalidOperationException>(() => { testQueue.Dequeue(); });
        }

        [TestMethod]
        public void PeekTest()
        {
            int testValue = 5;
            PG2Queue<int> testQueue = new PG2Queue<int>();

            testQueue.Enqueue(testValue);

            Assert.AreEqual(testValue, testQueue.Peek());
        }


        [TestMethod]
        public void PeekExceptionTest()
        {

            PG2Queue<int> testQueue = new PG2Queue<int>();

            Assert.ThrowsException<InvalidOperationException>(() => { testQueue.Peek(); });
        }

        [TestMethod]
        public void CountTest()
        {
            int[] testValues = new int[5] { 10, 20, 30, 40, 50 };

            PG2Queue<int> testQueue = new PG2Queue<int>();

            foreach (var testValue in testValues)
            {
                testQueue.Enqueue(testValue);
            }

            Assert.AreEqual(testValues.Length, testQueue.Count);
        }

        [TestMethod]
        public void ReverseTest()
        {
            int[] testValues = new int[5] { 10, 20, 30, 40, 50 };

            //TODO: change the class from Queue to PG2Queue
            //create the Queue
            PG2Queue<int> testQueue = new PG2Queue<int>();

            //add a test value to the Queue
            foreach (var testValue in testValues)
            {
                testQueue.Enqueue(testValue);
            }
            //the order of items in the Queue should be 10, 20, 30, 40, 50

            //TODO: call your reverse method
            testQueue.Reverse();
            //the Queue order should now be 50,40,30,20,10

            for (int i = testValues.Length - 1; i >= 0; i--)
            {
                int itemPopped = testQueue.Dequeue();
                Assert.AreEqual(testValues[i], itemPopped);
            }
        }
    }
}
