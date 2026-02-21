namespace CommonCode.UnitTests.Strings
{
    public class Tests
    {
        [TestCase("has Date 1950", "1950")]
        public void GetYearFrom(string text, string expected)
        {
            var r = StringsHelper.GetYearFrom(text);
            Assert.That(r, Is.EqualTo(expected));
        }

        [TestCase("no date", false)]
        [TestCase("no date 194a other", false)]
        [TestCase("no 194a other", false)]
        [TestCase("1920", false)]
        [TestCase("has Date 1950", true)]
        [TestCase("has 2024 321a", true)]
        public void HasDateNotAtStart(string text, bool expected)
        {
            var r = StringsHelper.HasDateNotAtStart(text);
            Assert.That(r, Is.EqualTo(expected));
        }

        [TestCase("value", "const string value = \"value\";")]
        [TestCase("Value With Spaces", "const string valueWithSpaces = \"Value With Spaces\";")]
        public void ShouldConvertTextToStringVar(string from, string to)
        {
            string text = StringsHelper.ConvertTextToStringVar(from);
            Assert.That(text, Is.EqualTo(to));
        }

        [TestCase("Text", "Text")]
        [TestCase("Text more words", "Text_more_words")]
        [TestCase("TextMore Words", "TextMore_words")]
        [TestCase("Text-More Words", "Text_more_words")]
        [TestCase("dot.dot", "dot_dot")]
        [TestCase("Can't", "Cant")]
        public void ShouldConvertTextToUnderscores(string from, string to)
        {
            string text = StringsHelper.ConvertTextToUnderscores(from);
            Assert.That(text, Is.EqualTo(to));
        }

        [TestCase("Text", "Text")]
        [TestCase("TextMoreWords", "Text more words")]
        [TestCase("TextMore Words", "Text more Words")]
        public void ShouldConvertToSentenceCase(string from, string to)
        {
            string text = StringsHelper.ToSentenceCase(from);
            Assert.That(text, Is.EqualTo(to));
        }
    }
}