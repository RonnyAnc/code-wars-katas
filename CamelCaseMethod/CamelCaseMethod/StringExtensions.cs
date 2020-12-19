using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace CamelCaseMethod {
    public static class StringExtensions {
        private const string Separator = " ";

        private static string ToCamelCase(string word) {
            var upperLetter = $"{word[0]}".ToUpper();
            return $"{upperLetter}{word.Substring(1)}";
        }
        
        public static string CamelCase(this string str) {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            
            return str
                .Trim()
                .Split(Separator)
                .Select(ToCamelCase)
                .Aggregate("", (acc, word) => acc + word);
        }
    }
}