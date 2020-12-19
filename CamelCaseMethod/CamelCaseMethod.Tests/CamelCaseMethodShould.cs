using NUnit.Framework;

namespace CamelCaseMethod.Tests {
    public class CamelCaseMethodShould {
        [Test]
        public void transform_single_character_to_upper() {
            Assert.AreEqual("H", "h".CamelCase());
        }
        
        [Test]
        public void transform_single_word_to_upper() {
            Assert.AreEqual("Hello", "hello".CamelCase());
        }
        
        [Test]
        public void transform_multiple_words_to_upper() {
            Assert.AreEqual("HelloDarkness", "hello darkness".CamelCase());
        }

        [Test]
        public void AcceptanceTests() {
            Assert.AreEqual("TestCase", "test case".CamelCase());
            Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
            Assert.AreEqual("SayHello", "say hello".CamelCase());
            Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
            Assert.AreEqual("", "".CamelCase());
        }
    }
}