using NUnit.Framework;
using XDASv2Net.Attributes;
using XDASv2Net.Extensions;

namespace XDASv2Net.Tests.Unit.Extensions
{
    [TestFixture]
    public class EnumExtensionsTest
    {
        [Test]
        public void EnumExtensions_GetAttribute()
        {
            //assemble & act
            var attribute1 = TestEnum.ENUM1.GetAttribute<EventInformationAttribute>();
            var attribute2 = TestEnum.ENUM2.GetAttribute<EventInformationAttribute>();

            //assert
            Assert.IsNotNull(attribute1);
            Assert.AreEqual("0.0.0.0", attribute1.EventIdentifier);
            Assert.IsNotNull(attribute2);
            Assert.IsNull(attribute2.EventIdentifier);
        }

        private enum TestEnum
        {
            [EventInformation("0.0.0.0")]
            ENUM1,
            ENUM2
        }
    }
}
