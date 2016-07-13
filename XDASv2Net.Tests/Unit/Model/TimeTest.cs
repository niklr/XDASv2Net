using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using XDASv2Net.Model;

namespace XDASv2Net.Tests.Unit.Model
{
    [TestFixture]
    public class TimeTest
    {
        [TestCase(-1)]
        [TestCase(101)]
        public void Time_Certainty_Range_Invalid(int certainty)
        {
            //assemble
            Time time = new Time();
            var context = new ValidationContext(time, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            time.Certainty = certainty;
            bool isValid = Validator.TryValidateObject(time, context, results, true);

            //assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("The field Certainty must be between 0 and 100.", results.First().ErrorMessage);
        }

        [TestCase(0)]
        [TestCase(50)]
        [TestCase(100)]
        public void Time_Certainty_Range_Valid(int certainty)
        {
            //assemble
            Time time = new Time();
            var context = new ValidationContext(time, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            time.Certainty = certainty;
            bool isValid = Validator.TryValidateObject(time, context, results, true);

            //assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(0, results.Count);
        }
    }
}
