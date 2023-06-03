﻿using eWolfMetaTagging.Helpers;
using System;
using System.IO;
using System.Xml.Serialization;

namespace eWolfMetaTagging.Data
{
    [Serializable]
    public class TagListHolders : BasicTagListBase
    {
        public static string GetFileName { get; } = "TagsStore.xml";

        public static TagListHolders Load()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(TagListHolders));
                using (var sr = new StreamReader(Configuration.Consts.WorkFolder + GetFileName))
                {
                    return (TagListHolders)xs.Deserialize(sr);
                }
            }
            catch
            {
                TagListHolders tlh = new TagListHolders();
                return tlh;
            }
        }

        public void Save()
        {
            Save(this, Configuration.Consts.WorkFolder + GetFileName);
        }

        private static void Save(TagListHolders taglist, string filename)
        {
            FileHelper.CreateBackUp(Configuration.Consts.WorkFolder, GetFileName);

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(TagListHolders));
                using (TextWriter tw = new StreamWriter(filename))
                {
                    xs.Serialize(tw, taglist);
                }
            }
            catch { }
        }
    }
}