using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFExperiment.OM;

namespace WPFExperimentUT.OM
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ConfigurationTest
    {

        private Configuration cut;

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

        [TestInitialize()]
        public void setup()
        {
            this.cut = new Configuration("Configuration1");
        }

        [TestMethod]
        public void TestVolume()
        {
            this.cut.Add("Teamspeak", 0.13m);
            Assert.AreEqual(this.cut.GetVolume("Teamspeak"), 0.13m);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Configuration1", this.cut.Name);
        }
    }
}
