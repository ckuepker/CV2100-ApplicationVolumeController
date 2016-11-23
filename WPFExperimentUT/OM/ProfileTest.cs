using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFExperiment.OM;

namespace WPFExperimentUT.OM
{
    /// <summary>
    /// Summary description for ProfileTest
    /// </summary>
    [TestClass]
    public class ProfileTest
    {

        private Profile _cut;
        public ProfileTest()
        {
            
        }

        [TestInitialize]
        public void setup()
        {
            this._cut = new Profile("DefaultProfile");
        }


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void testAdd()
        {
            this._cut.Add(new Configuration("Configuration1"));
            Assert.AreEqual(this._cut.Configurations.Count, 1);
        }
        
        [TestMethod]
        public void testName()
        {
            Assert.AreEqual("DefaultProfile", this._cut.Name);
        }
    }
}
