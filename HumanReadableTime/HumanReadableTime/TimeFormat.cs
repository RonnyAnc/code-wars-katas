namespace HumanReadableTime {
    public class TimeFormat {
        public static string GetReadableTime(int allSeconds) {
            return $"00:00:{allSeconds:D2}";
        }
    }
}