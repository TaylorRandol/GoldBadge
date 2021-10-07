using ChallengeThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ChallengeThree_Tests
    {
        [TestMethod]
        public void SetBadgeID()
        {
            BadgeClass badge = new BadgeClass();
            badge.BadgeID = 123456;

            double expected = 123456;
            double actual = badge.BadgeID;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetBadgeAndDoorsTest()
        {
            BadgeClass badge = new BadgeClass(123456d, new System.Collections.Generic.List<string>() { "A2", "A3" });
        }
    }
}
