using System.Net;
using ExtractModelDetails.Data;
using ExtractModelDetails.Extractors;

namespace ExtractModelDetails
{
    // https://www.modelraildatabase.com/hornby/locomotives
    internal class Program
    {
        private static void Main(string[] args)
        {
            var holder = new ModelLocoDetailsHolder();

            var e = new ModelDetailsExtractor();
            e.GetAllHornbyDetails(holder);

            ModelLocoDetailsHolder.Save(holder);
        }
    }
}