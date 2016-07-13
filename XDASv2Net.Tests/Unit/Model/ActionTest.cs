using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using XDASv2Net.Model;

namespace XDASv2Net.Tests.Unit.Model
{
    [TestFixture]
    public class ActionTest
    {
        [Test]
        public void Action_Outcome_RegularExpression_Required()
        {
            //assemble
            Action action = new Action();
            var context = new ValidationContext(action, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            action.Event = new Event();
            action.Time = new Time();
            action.ExtendedOutcome = "0";
            action.Outcome = "";
            bool isValid = Validator.TryValidateObject(action, context, results, true);

            //assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(2, results.Count);
            Assert.IsTrue(results.Any(r => r.ErrorMessage == "The Outcome field is required."));
            Assert.IsTrue(results.Any(r => r.ErrorMessage == "Validation for Event failed!"));
        }

        [TestCase("a")]
        [TestCase("abcd")]
        public void Action_Outcome_RegularExpression_Invalid(string outcome)
        {
            //assemble
            Action action = new Action();
            var context = new ValidationContext(action, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            action.Event = new Event();
            action.Time = new Time();
            action.ExtendedOutcome = "0";
            action.Outcome = outcome;
            bool isValid = Validator.TryValidateObject(action, context, results, true);

            //assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(2, results.Count);
            Assert.IsTrue(results.Any(r => r.ErrorMessage == "Invalid outcome code."));
            Assert.IsTrue(results.Any(r => r.ErrorMessage == "Validation for Event failed!"));
        }

        [TestCase("0")]
        [TestCase("1.0")]
        [TestCase("2.0.0")]
        [TestCase("3.0.0.0")]
        [TestCase("1234")]
        public void Action_Outcome_RegularExpression_Valid(string outcome)
        {
            //assemble
            Action action = new Action();
            var context = new ValidationContext(action, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            action.Event = new Event() { Id = "0" };
            action.Time = new Time();
            action.ExtendedOutcome = "0";
            action.Outcome = outcome;
            bool isValid = Validator.TryValidateObject(action, context, results, true);

            //assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(0, results.Count);
        }
    }
}
