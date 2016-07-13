using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using XDASv2Net.Model;

namespace XDASv2Net.Tests.Unit.Model
{
    [TestFixture]
    public class EventTest
    {
        [Test]
        public void Event_Id_RegularExpression_Required()
        {
            //assemble
            Event e = new Event();
            var context = new ValidationContext(e, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            e.Id = "";
            bool isValid = Validator.TryValidateObject(e, context, results, true);

            //assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("The Id field is required.", results.First().ErrorMessage);
        }

        [TestCase("a")]
        [TestCase("abcd")]
        public void Event_Id_RegularExpression_Invalid(string id)
        {
            //assemble
            Event e = new Event();
            var context = new ValidationContext(e, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            e.Id = id;
            bool isValid = Validator.TryValidateObject(e, context, results, true);

            //assert
            Assert.IsFalse(isValid);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Invalid event identifier.", results.First().ErrorMessage);
        }

        [TestCase("0")]
        [TestCase("1.0")]
        [TestCase("2.0.0")]
        [TestCase("3.0.0.0")]
        [TestCase("1234")]
        public void Event_Id_RegularExpression_Valid(string id)
        {
            //assemble
            Event e = new Event();
            var context = new ValidationContext(e, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            e.Id = id;
            bool isValid = Validator.TryValidateObject(e, context, results, true);

            //assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(0, results.Count);
        }
    }
}
