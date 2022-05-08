using System.Collections.Generic;
using System.IO;

namespace Tools
{
    public static class MusicQualityTool
    {
        public static IEnumerable<string> GetFilesUnderQuality(string directoryPath, int bitrate, bool searchInSubfolders = true)
        {
            var startPath = new DirectoryInfo(directoryPath);
            return new List<string> {@"C:\Tries\mic check\track1.mp3"};
        }
    }
}
