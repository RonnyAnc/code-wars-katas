namespace SplitStrings {
    public static class SplitString
    {
        public static string[] Solution(string str)
        {
            if (str.Length == 1) {
                str += "_";
            }
            return new []{str};
        }
    }
}