using RPG.RollDice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace RPGTest
{
    
    
    /// <summary>
    ///This is a test class for DiceParserTest and is intended
    ///to contain all DiceParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DiceParserTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        ///// <summary>
        /////A test for calcSubStringRoll
        /////</summary>
        //[TestMethod()]
        //public void calcSubStringRollTest()
        //{
        //    string s = string.Empty; // TODO: Initialize to an appropriate value
        //    ArrayList expected = null; // TODO: Initialize to an appropriate value
        //    ArrayList actual;
        //    actual = DiceParser.calcSubStringRoll(s);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        /// <summary>
        ///A test for Roll
        ///</summary>
        [TestMethod()]
        public void RollTest1()
        {
            string diceString = "1"; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1()
        {
            string diceString = "1d1"; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Add1()
        {
            string diceString = "1d1+1"; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Sub1()
        {
            string diceString = "1d1-1"; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Mul3()
        {
            string diceString = "1d1*3"; // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Mul0()
        {
            string diceString = "1d1*0"; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Add1Add1()
        {
            string diceString = "(1d1+1)+1"; // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Add1Sub1()
        {
            string diceString = "(1d1+1)-1"; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Add1Mul3()
        {
            string diceString = "(1d1+1)*3"; // TODO: Initialize to an appropriate value
            int expected = 6; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest1d1Add3d1()
        {
            string diceString = "1d1+3d1"; // TODO: Initialize to an appropriate value
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest3d1Sub1d1()
        {
            string diceString = "3d1-1d1"; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RollTest2d1Mul3d1()
        {
            string diceString = "2d1*3d1"; // TODO: Initialize to an appropriate value
            int expected = 6; // TODO: Initialize to an appropriate value
            int actual;
            actual = DiceParser.Roll(diceString);
            Assert.AreEqual(expected, actual);
        }
    }
}
