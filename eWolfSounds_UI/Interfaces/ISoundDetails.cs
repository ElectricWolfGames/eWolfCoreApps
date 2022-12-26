﻿namespace eWolfSounds_UI.Interfaces
{
    public interface ISoundDetails
    {
        string FullPath { get; set; }
        bool IsModified { get; }
        string Name { get; set; }

        string OrginalName { get; }
    }
}