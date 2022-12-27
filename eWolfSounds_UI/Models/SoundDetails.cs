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
                CheckName();
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

        private void CheckName()
        {
            var parts = _name.Split(" ");
            if (parts.Length != 2)
                return;

            if (!parts[0].ToUpper().Contains("TRACK"))
                return;

            _name = parts[1];
        }

        /*
         * private string NameCheck(string name)
        {
            var fileName = Path.GetFileName(name)

            var parts = name.Split("//").Split(" ");
            if (parts.Length != 2)
                return name;

            if (!parts[0].ToUpper().Contains("TRACK"))
                return name;

            return parts[1];
        }
         */
    }
}