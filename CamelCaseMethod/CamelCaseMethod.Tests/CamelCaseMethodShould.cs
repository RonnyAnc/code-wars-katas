using NUnit.Framework;

namespace CamelCaseMethod.Tests {
    public class CamelCaseMethodShould {
        [Test]
        public void transform_single_character_to_upper() {
            Assert.AreEqual("H", "h".CamelCase());
        }
        
        [Test, Ignore("Not implemented yet")]
        public void AcceptanceTests()
        {
            Assert.AreEqual("TestCase", "test case".CamelCase());
            Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
            Assert.AreEqual("SayHello", "say hello".CamelCase());
            Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
            Assert.AreEqual("", "".CamelCase());
        }
    }
}