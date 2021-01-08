namespace HumanReadableTime {
    public class TimeFormat {
        public static string GetReadableTime(int allSeconds) {
            var hours = allSeconds / 3600;
            var remainingSeconds = allSeconds % 3600;
            var minutes = remainingSeconds / 60;
            var seconds = remainingSeconds % 60;
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}