using System.IO;

namespace MassFileRenamer.Objects
{
    public static class GetNewFileInfo
    {
        public static FileInfo ForPath(string path)
        {
            FileInfo result;

            try
            {
                result = new FileInfo(path);
            }
            catch
            {
                return null;
            }

            return result;
        }
    }
}