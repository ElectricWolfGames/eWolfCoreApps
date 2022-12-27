using eWolfSounds_UI.Interfaces;
using eWolfTagHolders.Tags;
using System.IO;

namespace eWolfSounds_UI.Models
{
    public class SoundDetails : ISoundDetails
    {
        private string _extension = "";
        private bool _modified;
        private string _name = "";
        private string _orginalName = "";
        private string _path = "";
        private TagHolders _tagHolders;

        public string FullPath
        {
            get
            {
                return $"{_path}{_tagHolders.Line}{_extension}";
            }
            set
            {
                _orginalName = value;
                _extension = Path.GetExtension(value);
                _name = Path.GetFileNameWithoutExtension(value);
                _path = value.Replace(Path.GetFileName(value), string.Empty);
                _modified = false;
                _tagHolders = new TagHolders(_name);
            }
        }

        public TagHolders GetTagHolders
        {
            get
            {
                return _tagHolders;
            }
        }

        public bool IsModified
        {
            get
            {
                return _modified;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _tagHolders.Line = value;
                    _name = value;
                    _modified = true;
                }
            }
        }

        public string OrginalName
        {
            get
            {
                return _orginalName;
            }
        }

        public string PathOnly
        {
            get
            {
                return _path;
            }
        }

        public int TotalTags
        {
            get
            {
                return GetTagHolders.CountTags();
            }
        }

        public void UpdateTags()
        {
            Name = _tagHolders.Line;
        }
    }
}