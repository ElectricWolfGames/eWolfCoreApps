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
    }
}