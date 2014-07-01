using RPG.RollDice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RPGTest
{
    
    
    /// <summary>
    ///This is a test class for DieTest and is intended
    ///to contain all DieTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DieTest
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
        ///A test for Die Constructor
        ///</summary>
        [TestMethod()]
        public void DieConstructorTest()
        {
            int sides = 6; // TODO: Initialize to an appropriate value
            Die target = new Die(sides);
            Assert.AreEqual(sides, target.NumSides());
        }

        /// <summary>
        ///A test for Die Constructor
        ///</summary>
        [TestMethod()]
        public void DieConstructorTest1()
        {
            Die target = new Die();
            Assert.AreEqual(20, target.NumSides());
        }

        /// <summary>
        ///A test for Roll
        ///</summary>
        [TestMethod()]
        public void RollTest()
        {
            Die target = new Die(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Roll();
            Assert.IsTrue(actual >= 1, "The actualCount was not greater than 1");
            Assert.IsTrue(actual <= target.NumSides(), string.Format("The actualCount was greater than {0}", target.NumSides()));            
        }

        /// <summary>
        ///A test for NumSides
        ///</summary>
        [TestMethod()]
        public void NumSidesTest()
        {
            Die target = new Die(); // TODO: Initialize to an appropriate value
            int expected = 20; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumSides();
            Assert.AreEqual(expected, actual);            
        }
    }
}
