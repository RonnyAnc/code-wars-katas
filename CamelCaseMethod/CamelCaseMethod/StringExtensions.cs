using System;

namespace CamelCaseMethod {
    public static class StringExtensions {
        public static string CamelCase(this string str) {
            return $"{str[0].ToString().ToUpper()}{str.Substring(1)}";
        }
    }
}