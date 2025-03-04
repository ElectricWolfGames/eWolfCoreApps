using System.Text.RegularExpressions;

namespace CommonCode
{
    public static class StringsHelper
    {
        public static string GetYearFrom(string text)
        {
            string pattern = @"\b\d{4}\b";

            Match match = Regex.Match(text, pattern);

            if (match.Success)
            {
                return match.Value;
            }
            return string.Empty;
        }

        public static bool HasDateNotAtStart(string text)
        {
            string pattern = "^(?!\\d{4}\\b).*\\b\\d{4}\\b";
            return Regex.IsMatch(text, pattern);
        }
    }
}