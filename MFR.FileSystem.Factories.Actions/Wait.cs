using System.Threading.Tasks;

namespace MFR.FileSystem.Factories.Actions
{
    /// <summary>
    /// Exposes static methods to hold up components of a software system while we wait
    /// for a certain action to be taken elsewhere, or for files and folders to become
    /// accessible.
    /// </summary>
    public static class Wait
    {
        /// <summary>
        /// Blocks the calling thread until the
        /// <see cref="M:MFR.FileSystem.Factories.Actions.Is.FolderWriteable" /> method
        /// returns <see langword="true" /> for the folder having the specified
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the folder to be examined.
        /// </param>
        public static async void ForFolderToBecomeWriteable(string pathname)
        {
            try
            {
                while (!Is.FolderWriteable(pathname)) await Task.Delay(500);
            }
            catch
            {
                //Ignored.
            }
        }
    }
}