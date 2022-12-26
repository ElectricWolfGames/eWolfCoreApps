using eWolfSounds_UI.Configuration;
using System.Collections.Generic;

namespace eWolfSounds_UI.Models
{
    public class OptionsHolder
    {
        private readonly List<string> _pathsToSearch = new List<string>();

        public OptionsHolder()
        {
            _pathsToSearch.Add(SoundConstant.LibraryPath);
        }

        public List<string> PathsToSearch => _pathsToSearch;
    }
}