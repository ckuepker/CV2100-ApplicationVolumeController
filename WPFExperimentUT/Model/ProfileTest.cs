using System;
using System.Text;
using System.Collections.Generic;
using WPFExperiment.Model;
using NUnit.Framework;

namespace WPFExperimentUT.Model
{
    /// <summary>
    /// Summary description for ProfileTest
    /// </summary>
    [TestFixture]
    public class ProfileTest
    {

        private Profile profile;
        public ProfileTest()
        {
            
        }

        [SetUp]
        public void setup()
        {
            this.profile = new Profile("DefaultProfile");
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

        [Test]
        public void testAdd()
        {
            this.profile.Add(new Configuration("Configuration1"));
            Assert.That(profile.Configurations.Count, Is.EqualTo(1)); 
        }

        [Test]
        public void testName()
        {
            Assert.That(profile.Name, Is.EqualTo("DefaultProfile"));
        }
    }
}
