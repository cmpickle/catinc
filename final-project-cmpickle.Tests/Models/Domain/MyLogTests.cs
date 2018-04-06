using NUnit.Framework;
using final_project_cmpickle.Models.Domain;
using System;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class MyLogTests
    {
        private Log log;

        [SetUp]
        public void SetUp()
        {
            log = new Log();
        }

        [Test]
        public void SetLogIdTest()
        {
            log.LogID = 17;

            Assert.That(log.LogID == 17);
        }

        [Test]
        public void SetLogUserId()
        {
            log.UserID = 18;

            Assert.That(log.UserID == 18);
        }

        [Test]
        public void SetLogTimestamp()
        {
            log.LogTimestamp = new DateTime(2018, 4, 5);

            Assert.That(log.LogTimestamp.CompareTo(new DateTime(2018, 4, 5)) == 0);
        }

        [Test]
        public void SetLogLevel()
        {
            log.LogLevel = 19;

            Assert.That(log.LogLevel == 19);
        }

        [Test]
        public void SetLogMessage()
        {
            log.LogMessage = "Use the force Luke!";

            Assert.That(log.LogMessage.Equals("Use the force Luke!"));
        }
    }
}