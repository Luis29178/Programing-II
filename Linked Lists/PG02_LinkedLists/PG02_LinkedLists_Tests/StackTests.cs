using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG02_LinkedLists;

namespace PG02_LinkedLists_Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void PushPopTest()
        {
            int[] testValues = new int[5] { 10, 20, 30, 40, 50 };

            PG2Stack<int> testStack = new PG2Stack<int>();


            foreach (var testValue in testValues)
            {
                testStack.Push(testValue);
            }

            for (int i = testValues.Length - 1; i >= 0; i--)
            {
                int itemPopped = testStack.Pop();
                Assert.AreEqual(testValues[i], itemPopped);
            }

        }


        
        [TestMethod]
        public void PopExceptionTest()
        {
            
            PG2Stack<int> testStack = new PG2Stack<int>();

            
            Assert.ThrowsException<InvalidOperationException>(() => { testStack.Pop(); });
        }

        [TestMethod]
        public void PeekTest()
        {
            int testValue = 5;

            PG2Stack<int> testStack = new PG2Stack<int>();

            testStack.Push(testValue);

            Assert.AreEqual(testValue, testStack.Peek());
        }


        /// <summary>
        /// Test that the Peek method will throw an InvalidOperationException if the queue is empty
        /// </summary>
        [TestMethod]
        public void PeekExceptionTest()
        {

            PG2Stack<int> testStack = new PG2Stack<int>();

            Assert.ThrowsException<InvalidOperationException>(() => { testStack.Peek(); });
        }

        [TestMethod]
        public void CountTest()
        {
            int[] testValues = new int[5] { 10, 20, 30, 40, 50 };

            PG2Stack<int> testStack = new PG2Stack<int>();

            foreach (var testValue in testValues)
            {
                testStack.Push(testValue);
            }

            Assert.AreEqual(testValues.Length, testStack.Count);
        }

        [TestMethod]
        public void ReverseTest()
        {
            int[] testValues = new int[5] { 10, 20, 30, 40, 50 };

            //TODO: change the class from Stack to PG2Stack
            //create the stack
            PG2Stack<int> testStack = new PG2Stack<int>();

            //add a test value to the stack
            foreach (var testValue in testValues)
            {
                testStack.Push(testValue);
            }
           

            
            testStack.Reverse();
            
            

            for (int i = 0; i < testValues.Length; i++)
            {
                int itemPopped = testStack.Pop();
                Assert.AreEqual(testValues[i], itemPopped);
            }
        }
    }
}
