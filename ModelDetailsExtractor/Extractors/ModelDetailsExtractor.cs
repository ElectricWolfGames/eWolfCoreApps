using ExtractModelDetails.Data;
using ExtractModelDetails.Helpers;
using System.Net;
using System.Runtime.CompilerServices;

namespace ExtractModelDetails.Extractors
{
    public class ModelDetailsExtractor
    {
        private string rawHornbyFile;

        public ModelDetailsExtractor()
        {
            WebClient client = new WebClient(); // TODO Use HTTPSClient
            Stream stream = client.OpenRead("https://www.modelraildatabase.com/hornby/locomotives");
            StreamReader reader = new StreamReader(stream);
            rawHornbyFile = reader.ReadToEnd();
        }

        public void GetAllHornbyDetails(ModelLocoDetailsHolder modelLocoDetailsHolder)
        {
            var startIndex = rawHornbyFile.IndexOf("table-group-divider");
            var endIndex = rawHornbyFile.IndexOf("</main>", startIndex);

            var subscript = rawHornbyFile.Substring(startIndex, endIndex - startIndex);

            var items = subscript.Split("</tr>");

            foreach (var item in items)
            {
                ModelLocoDetails modelLocoDetails = ParseItem(item);
                if (modelLocoDetails != null)
                {
                    modelLocoDetails.Manufacturers = "Hornby";
                    modelLocoDetailsHolder.ModelLocoDetails.Add(modelLocoDetails);
                }
            }
        }

        public ModelLocoDetails ParseItem(string subscript)
        {
            if (subscript.Contains("/table"))
                return null;

            ModelLocoDetails modelLocoDetails = new ModelLocoDetails();
            var item = subscript.Split("</td>", StringSplitOptions.RemoveEmptyEntries);

            modelLocoDetails.CatalogueId = HTMLParser.GetValue(item[0]);
            modelLocoDetails.Year = HTMLParser.GetValue(item[1]);
            modelLocoDetails.RunningNumber = HTMLParser.GetValue(item[2]);
            modelLocoDetails.Era = HTMLParser.GetValue(item[6]);
            modelLocoDetails.Name = HTMLParser.GetValue(item[3]);

            return modelLocoDetails;
        }
    }
}