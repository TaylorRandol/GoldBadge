using ChallengeTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Challenge_Two_Tests
    {
        [TestMethod]
        public void OriginalDateTimeTests_DidNotEndUpUsingThisButItHelpedMeSolveAFewThings()
        {
            ClaimClass claimClass = new ClaimClass();
            DateTime dt = new DateTime(2021, 12, 12);

            claimClass.DateOfIncident = dt;

            DateTime expected = DateTime.Now;
            DateTime actual = claimClass.DateOfIncident;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void DateTimeTesting()
        {
            ClaimClass claim = new ClaimClass();
            DateTime date1 = new DateTime(2021, 10, 5);
            DateTime date2 = new DateTime(2021, 11, 5);
            claim.DateOfIncident = date1;
            claim.DateOfClaim = date2;

            TimeSpan span = date2 - date1;
            TimeSpan time = TimeSpan.FromDays(30);

            Assert.IsFalse(span <= time);
        }
        [TestMethod]
        public void SetID()
        {
            ClaimClass claim = new ClaimClass();
            claim.ClaimID = 1234567;
            double expected = 1234567;
            double actual = claim.ClaimID;

            Assert.AreEqual(expected, actual);
        }
    }
}
