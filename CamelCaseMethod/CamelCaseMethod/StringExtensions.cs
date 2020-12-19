using System;
using System.Linq;

namespace CamelCaseMethod {
    public static class StringExtensions {
        private const string Separator = " ";

        public static string CamelCase(this string str) {
            static string ToUpperCamelCase(string word) => 
                $"{word[0].ToString().ToUpper()}{word.Substring(1)}";

            return str
                .Split(Separator)
                .Select(ToUpperCamelCase)
                .Aggregate((acc, word) => acc + word);
        }
    }
}