using eWolfTagHolders.Helpers;
using FluentAssertions;

namespace eWolfTagHolders.UnitTests.Helpers
{
    public class TagHelperTests
    {
        [TestCase("0123 A D", "0123", "a", "d")]
        [TestCase("0123 A PartOfWords", "0123", "PartOfWords", "a")]
        public void ShouldCreateFileName(string expected, params string[] words)
        {
            TagHelper.CreateFileNameFromTags(words).Should().Be(expected);
        }

        [TestCase("Name", "Name")]
        [TestCase("Name ", "Name")]
        [TestCase("Name Test Split", "Name", "Test", "Split")]
        [TestCase("    Name        Test   Split  ", "Name", "Test", "Split")]
        public void ShouldGetAllTags(string name, params string[] tags)
        {
            string[] parts = TagHelper.GetTagsFromName(name);

            foreach (string tag in tags)
            {
                parts.Should().Contain(tag);
            }
        }

        [TestCase("word", "Word")]
        [TestCase("word with more", "WordWithMore")]
        [TestCase("    word with    more", "WordWithMore")]
        [TestCase("IveGotPacalAllReady", "IveGotPacalAllReady")]
        [TestCase("I've Got ", "IveGot")]
        public void ShouldMakePascalCase(string line, string expectedLine)
        {
            TagHelper.MakePascalCase(line).Should().Be(expectedLine);
        }
    }
}