using System.Diagnostics;
using System.Xml.Serialization;

namespace ExtractModelDetails.Data
{
    public class ModelLocoDetailsHolder
    {
        public const string FileName = @"E:\temp\LocoDetails.xml";
        public List<ModelLocoDetails> ModelLocoDetails = new List<ModelLocoDetails>();

        public static void Save(ModelLocoDetailsHolder modelLocoDetailsHolder)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ModelLocoDetailsHolder));

            using (TextWriter tw = new StreamWriter(FileName))
            {
                xs.Serialize(tw, modelLocoDetailsHolder);
            }
        }
    }
}