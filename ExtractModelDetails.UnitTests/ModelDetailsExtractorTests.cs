using ExtractModelDetails.Data;
using ExtractModelDetails.Extractors;

namespace ExtractModelDetails.UnitTests
{
    public class Tests
    {
        [Test]
        public void ShouldGetAllHornbyModels()
        {
            ModelDetailsExtractor modelDetailsExtractor = new ModelDetailsExtractor();

            var holder = new ModelLocoDetailsHolder();
            modelDetailsExtractor.GetAllHornbyDetails(holder);

            Assert.That(holder.ModelLocoDetails.Count, Is.EqualTo(3047));
        }

        [Test]
        public void ShouldParseItemR033()
        {
            string subscript = "table-group-divider\">\r\n                        <tr>\r\n                            <td><a Title=\"British Railways Standard 7, British Railways (Lined Green with Early Emblem) &quot;Morning Star&quot;\" href=\"/locomotives/details/3054/\">R033</a></td>\r\n                            <td class=\"text-center\">1982</td>\r\n                            <td>70021</td>\r\n                            <td>British Railways Standard 7, British Railways (Lined Green with Early Emblem) &quot;Morning Star&quot;</td>\r\n                            <td class=\"text-center\">OO</td>\r\n                            <td class=\"text-center\">P</td>\r\n                            <td class=\"text-center\">4</td>\r\n                            <td>No</td>\r\n                        ";

            ModelDetailsExtractor modelDetailsExtractor = new ModelDetailsExtractor();
            var model = modelDetailsExtractor.ParseItem(subscript);

            Assert.That(model.Year, Is.EqualTo("1982"));
            Assert.That(model.CatalogueId, Is.EqualTo("R033"));
            Assert.That(model.RunningNumber, Is.EqualTo("70021"));
            Assert.That(model.Era, Is.EqualTo("4"));
            Assert.That(model.Name, Is.EqualTo("British Railways Standard 7, British Railways (Lined Green with Early Emblem) &quot;Morning Star&quot;"));
        }
    }
}