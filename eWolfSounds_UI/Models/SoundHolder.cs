using eWolfSounds_UI.Helpers;
using eWolfSounds_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace eWolfSounds_UI.Models
{
    [Serializable]
    public class SoundHolder : ISaveable
    {
        public List<SoundItemData> SoundItems = new List<SoundItemData>();

        // need to have many collection - not just the one
        private readonly string _outputFolder;

        [NonSerialized]
        private bool _modified = false;

        public SoundHolder()
        {
        }

        public SoundHolder(string outputFolder)
        {
            _outputFolder = outputFolder;
            Load();
        }

        public string GetFileName
        {
            get
            {
                return "SoundItemsHolderA";
            }
        }

        public void Add(SoundItemData item)
        {
            lock (SoundItems)
            {
                if (SoundItems.Any(x => x.FullPath == item.FullPath))
                    return;

                SoundItems.Add(item);
                _modified = true;
            }
        }

        public void Load()
        {
            PersistenceHelper<SoundHolder> ph = new PersistenceHelper<SoundHolder>(_outputFolder);

            string outputFileName = Path.Combine(_outputFolder, GetFileName);
            SoundHolder tempSoundHolder = ph.LoadDataSingle(outputFileName);

            SoundItems.Clear();
            if (tempSoundHolder != null)
            {
                SoundItems.AddRange(tempSoundHolder.SoundItems);
            }
        }

        public void SaveIfNeeded(bool forcedSave = false)
        {
            if (_modified || forcedSave)
                Save();
        }

        private void Save()
        {
            lock (SoundItems)
            {
                PersistenceHelper<SoundHolder> ph = new PersistenceHelper<SoundHolder>(_outputFolder);
                ph.SaveDataSingle(this);
            }
            _modified = false;
        }
    }
}