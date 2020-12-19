using System.Collections.Generic;
using System.Linq;

namespace SplitStrings {
    public static class SplitString
    {
        private const char completionCharacter = '_';

        private static List<string> SplitByPairs(string input) {
            var pairs = new List<string>();
            for (var i = 0; i < input.Length; i += 2) {
                pairs.Add($"{input[i]}{input[i + 1]}");
            }
            return pairs;
        }
        
        public static string[] Solution(string str) {
            bool HasEvenLength() => str.Length % 2 == 0;
            var sanitized = HasEvenLength() ? str : $"{str}{completionCharacter}";
            var pairs = SplitByPairs(sanitized);
            return pairs.ToArray();
        }
    }
}