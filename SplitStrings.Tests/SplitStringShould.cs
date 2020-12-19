using NUnit.Framework;

namespace SplitStrings.Tests {
    [TestFixture]
    public class SplitStringShould {
        [Test]
        public void return_same_value_when_input_has_only_two_characters() {
            const string simpleInput = "ab";
            Assert.AreEqual(new string[] {"ab"}, SplitString.Solution(simpleInput));
        }

        [Test]
        public void add_underscore_when_odd_input() {
            const string simpleOddInput = "a";
            Assert.AreEqual(new[] {"a_"}, SplitString.Solution(simpleOddInput));
        }
        
        [Test]
        public void split_multiple_pairs() {
            const string simpleOddInput = "abcd";
            Assert.AreEqual(new[] {"ab", "cd"}, SplitString.Solution(simpleOddInput));
        }

        [Test, Ignore("Not yet")]
        public void AcceptanceTests() {
            Assert.AreEqual(new string[] {"ab", "c_"}, SplitString.Solution("abc"));
            Assert.AreEqual(new string[] {"ab", "cd", "ef"}, SplitString.Solution("abcdef"));
        }
    }
}