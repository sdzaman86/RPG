using RPG.RollDice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DiceTest
{
    
    
    /// <summary>
    ///This is a test class for DiceTest and is intended
    ///to contain all DiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DiceTest
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


        /// <summary>
        ///A test for Dice Constructor
        ///</summary>
        [TestMethod()]        
        public void DiceConstructorTest()
        {
            int numDice = 1; // TODO: Initialize to an appropriate value
            int numSides = 6; // TODO: Initialize to an appropriate value
            Dice target = new Dice(numDice, numSides);
            Assert.AreEqual(numDice, target.NumDice());
            Assert.AreEqual(numSides, target.GetDice().First().NumSides());
        }

        /// <summary>
        ///A test for Dice Constructor
        ///</summary>
        [TestMethod()]        
        public void DiceConstructorTest1()
        {
            int numDice = 1; // TODO: Initialize to an appropriate value
            Dice target = new Dice(numDice);
            Assert.AreEqual(numDice, target.NumDice());
            Assert.AreEqual(20, target.GetDice().First().NumSides());
        }

        /// <summary>
        ///A test for Dice Constructor
        ///</summary>
        [TestMethod()]        
        public void DiceConstructorTest2()
        {
            Dice target = new Dice();
            Assert.AreEqual(1, target.NumDice());
            Assert.AreEqual(20, target.GetDice().First().NumSides());
        }

        /// <summary>
        ///A test for Roll
        ///</summary>
        [TestMethod()]        
        public void RollTest()
        {
            Dice target = new Dice(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Roll();
            Assert.IsTrue(actual >= 1, "The actualCount was not greater than 1");
            Assert.IsTrue(actual <= target.GetDice().First().NumSides(), string.Format("The actualCount was greater than {0}", target.GetDice().First().NumSides()));   
        }

        /// <summary>
        ///A test for Roll
        ///</summary>
        [TestMethod()]        
        public void RollTest2()
        {
            Dice target = new Dice(2); // TODO: Initialize to an appropriate value
            int numDice = target.GetDice().Count();
            int actual;
            actual = target.Roll();
            Assert.IsTrue(actual >= 1 * numDice, "The actualCount was not greater than 1");
            Assert.IsTrue(actual <= target.GetDice().First().NumSides() * numDice, string.Format("The actualCount was greater than {0}", target.GetDice().First().NumSides() * numDice));
        }

        /// <summary>
        ///A test for GetDice
        ///</summary>
        [TestMethod()]
        public void GetDiceTest()
        {
            Dice target = new Dice(); // TODO: Initialize to an appropriate value
            IEnumerable<Die> actual;
            actual = target.GetDice();
            Assert.AreEqual(1, actual.Count());
        }

        /// <summary>
        ///A test for NumDice
        ///</summary>
        [TestMethod()]
        public void NumDiceTest()
        {
            Dice target = new Dice(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumDice();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for NumSides
        ///</summary>
        [TestMethod()]
        public void NumSidesTest()
        {
            Dice target = new Dice(); // TODO: Initialize to an appropriate value
            int expected = 20; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumSides();
            Assert.AreEqual(expected, actual);
        }
    }
}
