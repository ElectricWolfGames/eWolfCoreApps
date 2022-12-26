﻿using eWolfSounds_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace eWolfSounds_UI.Helpers
{
    public class PersistenceHelper<T>
    {
        private readonly string _outputFolder;

        public PersistenceHelper(string outputFolder)
        {
            _outputFolder = outputFolder;
            Directory.CreateDirectory(_outputFolder);
        }

        public List<T> LoadData()
        {
            List<T> items = new List<T>();

            string[] files = Directory.GetFiles(_outputFolder);
            foreach (string file in files)
            {
                items.Add(LoadDataSingle(file));
            }

            return items;
        }

        public T LoadDataSingle(string file)
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                T sd = (T)formatter.Deserialize(stream);
                stream.Close();

                return sd;
            }
            catch (Exception)
            {
                if (stream != null)
                    stream.Close();
            }
            return default(T);
        }

        public bool SaveData(IEnumerable<ISaveable> saveableItems)
        {
            bool allSaved = true;
            foreach (ISaveable saveable in saveableItems)
            {
                if (saveable == null)
                    continue;

                allSaved &= SaveDataSingle(saveable);
            }
            return allSaved;
        }

        public bool SaveDataSingle(ISaveable saveable)
        {
            string outputFileName = Path.Combine(_outputFolder, saveable.GetFileName);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = null;
            try
            {
                stream = StreamFactory.GetStream(outputFileName);
                if (SaveToStream(stream, formatter, saveable))
                    stream.Close();
                else
                    return false;
            }
            catch
            {
                if (stream != null)
                    stream.Close();

                return false;
            }
            return true;
        }

        private static bool SaveToStream(Stream stream, IFormatter formatter, object objectToSave)
        {
            try
            {
                formatter.Serialize(stream, objectToSave);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}