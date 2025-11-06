using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCrontab.Advanced.Tests
{
    // Why do we test constants?  To ensure dictionaries that
    // use them are updated as soon as a new value is added!
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void VerifyConstants()
        {
            ValidateExists(Constants.ExpectedFieldCounts);
            ValidateExists(Constants.MaximumDateTimeValues);
            ValidateExists(Constants.CronDays);
        }

        private static void ValidateExists<T>(IDictionary<T, int> dictionary) where T : struct, Enum
        {
            Assert.IsNotNull(dictionary);

            foreach (T value in Enum.GetValues(typeof(T)))
                Assert.IsTrue(dictionary.ContainsKey(value), $"Contains <{Enum.GetName(typeof(T), value)}>");
        }
    }
}
