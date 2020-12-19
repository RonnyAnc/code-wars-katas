using System;
using System.Linq;

namespace CamelCaseMethod {
    public static class StringExtensions {
        public static string CamelCase(this string str) {
            return str
                .Split(" ")
                .Select(word => $"{word[0].ToString().ToUpper()}{word.Substring(1)}")
                .Aggregate((acc, word) => acc + word);
        }
    }
}