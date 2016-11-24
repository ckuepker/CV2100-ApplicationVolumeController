using System;
using System.Text;
using System.Collections.Generic;
using WPFExperiment.OM;
using NUnit.Framework;

namespace WPFExperimentUT.OM
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestFixture]
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

        [SetUp]
        public void setup()
        {
            this.cut = new Configuration("Configuration1");
        }

        [Test]
        public void TestVolume()
        {
            this.cut.Add("Teamspeak", 0.13m);
            Assert.That(this.cut.GetVolume("Teamspeak"), Is.EqualTo(0.13m));
        }

        [Test]
        public void TestName()
        {
            Assert.That(this.cut.Name, Is.EqualTo("Configuration1"));
        }
    }
}
