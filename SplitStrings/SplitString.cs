using System.Collections.Generic;
using System.Linq;

namespace SplitStrings {
    public static class SplitString
    {
        private const char completionCharacter = '_';

        private static string[] SplitByPairs(string input) {
            return Enumerable.Range(0, input.Length)
                .Where(index => index % 2 == 0)
                .Select(index => input.Substring(index, 2))
                .ToArray();
        }
        
        public static string[] Solution(string str) {
            bool HasEvenLength() => str.Length % 2 == 0;
            var sanitized = HasEvenLength() ? str : $"{str}{completionCharacter}";
            return SplitByPairs(sanitized);
        }
    }
}