using System;

namespace eWolfSounds_UI.Models
{
    [Serializable]
    public class SoundItemData
    {
        private string _name;

        //private TagHolder _tagHolder;

        public string FullPath { get; set; }

        public string ImagePath { get; set; }

        public float Length { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                //TagOptionsService tos = ServiceLocator.Instance.GetService<TagOptionsService>();
                //_tagHolder = new TagHolder(tos.TagOptions);
                //_tagHolder.SplitName(_name);
            }
        }

        /*        public List<TagData> Tags
                {
                    get
                    {
                        return _tagHolder.Tags;
                    }
                }

                public bool AddTag(string name)
                {
                    return _tagHolder.Add(name);
                }

                public void Clear()
                {
                    _tagHolder.ClearTags();
                }*/
    }
}