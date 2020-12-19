using System.Collections.Generic;

namespace SplitStrings {
    public static class SplitString
    {
        public static string[] Solution(string str) {
            var sanitized = (str.Length % 2 == 0) ? str : $"{str}_";
            var splittedInput = new List<string>();
            for (var i = 0; i < sanitized.Length; i += 2) {
                splittedInput.Add($"{sanitized[i]}{sanitized[i + 1]}");
            }
            return splittedInput.ToArray();
        }
    }
}