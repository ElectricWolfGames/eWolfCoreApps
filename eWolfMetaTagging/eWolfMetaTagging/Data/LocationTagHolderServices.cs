﻿using System.IO;
using System.Configuration;
using System.Xml.Serialization;
using eWolfMetaTagging.Services;
using eWolfMetaTagging.Helpers;

namespace eWolfMetaTagging.Data
{
    public class LocationTagHolderServices : BasicTagListBase
    {
        public static string GetFileName { get; } = "LocationTags.xml";

        public static LocationTagHolderServices GetLocationTagHolderServices
        {
            get
            {
                return ServiceLocator.Instance.GetService<LocationTagHolderServices>();
            }
        }

        public static LocationTagHolderServices Load()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(LocationTagHolderServices));
                using (var sr = new StreamReader(Configuration.Consts.WorkFolder + GetFileName))
                {
                    return (LocationTagHolderServices)xs.Deserialize(sr);
                }
            }
            catch
            {
            }

            LocationTagHolderServices locationTagHolderServices = new LocationTagHolderServices();
            return locationTagHolderServices;
        }

        public void Save()
        {
            LocationTagHolderServices.Save(this);
        }

        private static void Save(LocationTagHolderServices taglist)
        {
            FileHelper.CreateBackUp(Configuration.Consts.WorkFolder, GetFileName);

            XmlSerializer xs = new XmlSerializer(typeof(LocationTagHolderServices));
            using (TextWriter tw = new StreamWriter(Configuration.Consts.WorkFolder + GetFileName))
            {
                xs.Serialize(tw, taglist);
            }
        }
    }
}
