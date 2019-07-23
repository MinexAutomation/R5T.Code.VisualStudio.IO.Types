using System;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Code.VisualStudio.IO
{
    public static class Utilities
    {
        public static string GetProjectName(string projectFilePath)
        {
            var projectName = PathUtilities.GetFileNameWithoutExtension(projectFilePath);
            return projectName;
        }
    }
}
