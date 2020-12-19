using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace CamelCaseMethod {
    public static class StringExtensions {
        private const string Separator = " ";

        private static string ToCamelCase(string word) {
            if (string.IsNullOrEmpty(word)) return string.Empty;

            var upperLetter = $"{word[0]}".ToUpper();
            return $"{upperLetter}{word.Substring(1)}";
        }
        
        public static string CamelCase(this string str) {
            return str
                .Trim()
                .Split(Separator)
                .Select(ToCamelCase)
                .Aggregate("", (acc, word) => acc + word);
        }
    }
}