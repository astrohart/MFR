using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Factories.Actions
{
    public static class Wait
    {
        public static async void ForFolderToBecomeWriteable(string pathname)
        {
            try
            {
                while (!Is.FolderWriteable(pathname))
                {
                    await Task.Delay(500);
                }
            }
            catch
            {
                //Ignored.
            }
        }
    }
}
