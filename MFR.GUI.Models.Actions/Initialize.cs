using MFR.GUI.Models.Constants;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Constants;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Models.Actions
{
    /// <summary>
    /// Exposes static methods to initialize data sets.
    /// </summary>
    public static class Initialize
    {
        /// <summary>
        /// Provides the initial (default) value of the list of operations that are to be
        /// performed.
        /// </summary>
        /// <returns>
        /// The initial (default) value of the list of operations that are to be
        /// performed.
        /// </returns>
        public static List<OperationTypeInfo> OperationList()
        {
            var result = new List<OperationTypeInfo>();

            try
            {
                result = new List<OperationTypeInfo> {
                    new OperationTypeInfo {
                        Enabled = true,
                        Name = OperationNames.RenameFilesInFolder,
                        OperationType = OperationType.RenameFilesInFolder
                    },
                    new OperationTypeInfo {
                        Enabled = true,
                        Name = OperationNames.RenameSubFolders,
                        OperationType = OperationType.RenameSubFolders
                    },
                    new OperationTypeInfo {
                        Enabled = true,
                        Name = OperationNames.ReplaceTextInFiles,
                        OperationType = OperationType.ReplaceTextInFiles
                    }
                };
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new List<OperationTypeInfo>();
            }

            return result;
        }
    }
}