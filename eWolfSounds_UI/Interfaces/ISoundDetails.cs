using eWolfTagHolders.Tags;

namespace eWolfSounds_UI.Interfaces
{
    public interface ISoundDetails
    {
        string FullPath { get; set; }
        TagHolders GetTagHolders { get; }
        bool IsModified { get; }
        string Name { get; set; }
        string OrginalName { get; }
        string PathOnly { get; }
        int TotalTags { get; }

        void UpdateTags();
    }
}