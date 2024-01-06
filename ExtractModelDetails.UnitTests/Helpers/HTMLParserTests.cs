using ExtractModelDetails.Helpers;

namespace ExtractModelDetails.UnitTests.Helpers
{
    public class HTMLParserTests
    {
        [TestCase("<td class=\"text-center\">1982", "1982")]
        [TestCase("<td>70021", "70021")]
        [TestCase("<td><a Title=\"British Railways Standard 7, British Railways (Lined Green with Early Emblem) &quot;Morning Star&quot;\" href=\"/locomotives/details/3054/\">R033</a>", "R033")]
        [TestCase("<td>British Railways Standard 7, British Railways (Lined Green with Early Emblem) &quot;Morning Star&quot;", "British Railways Standard 7, British Railways (Lined Green with Early Emblem) &quot;Morning Star&quot;")]
        public void GetValueShouldReturnValue(string data, string result)
        {
            var r = HTMLParser.GetValue(data);
            Assert.That(r, Is.EqualTo(result));
        }
    }
}