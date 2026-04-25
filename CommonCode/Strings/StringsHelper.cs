using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommonCode
{
    public static class StringsHelper
    {
        public static string ConvertTextToStringVar(string sentence)
        {
            string words = ToSentenceCase(sentence);

            string wordSpaces = RemovedSpaces(words);
            wordSpaces = char.ToLower(wordSpaces[0]) + wordSpaces.Substring(1);

            string text = $"const string {wordSpaces} = \"{words}\";";

            return text;
        }

        public static string ConvertTextToUnderscores(string sentence)
        {
            sentence = sentence.Replace('-', ' ');
            sentence = sentence.Replace("\'", "");
            sentence = sentence.Replace('.', '_');
            string[] words = sentence.Split(' ');

            if (words.Length > 1)
            {
                for (int i = 1; i < words.Length; i++)
                {
                    words[i] = words[i].ToLower();
                }
            }

            return string.Join("_", words);
        }

        public static string GetBoxBrackets(string input)
        {
            int start = input.IndexOf('[');
            int end = input.IndexOf(']', start + 1);

            if (start != -1 && end != -1)
            {
                return input.Substring(start + 1, end - start - 1);
            }
            return string.Empty;
        }

        public static string[] GetWordTypes(string input)
        {
            return input.Split(',');
        }

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

        public static string MakeFileNameSafe(string text)
        {
            text = text.Replace(":", string.Empty);

            return text.Trim();
        }

        public static string RemovedSpaces(string sentence)
        {
            return sentence.Replace(" ", "");
        }

        public static string ToSentenceCase(string word)
        {
            return Regex.Replace(word, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
        }
    }
}