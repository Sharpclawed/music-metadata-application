using System.Linq;
using NUnit.Framework;
using Tools;

namespace ToolsUnitTests
{
    public class MusicQualityToolTests
    {
        [Test]
        public void ResultFiles_HaveSamePrefixAsInputFolder()
        {
            var inputData = @"C:\Tries\mic check";
            var resultData = MusicQualityTool.GetFilesUnderQuality(inputData, 320);

            Assert.True(resultData.All(res => res.StartsWith(inputData)));
        }
    }
}