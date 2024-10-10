using MFR.GUI.Models.Factories;
using MFR.GUI.Models.Interfaces;
using MFR.Operations.Constants;
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
        public static List<IOperationTypeInfo> OperationList()
        {
            var result = new List<IOperationTypeInfo>();

            try
            {
                result = new List<IOperationTypeInfo> {
                    MakeNewOperationTypeInfo.FromScratch()
                                            .HavingOperationType(
                                                OperationType
                                                    .RenameFilesInFolder
                                            )
                                            .AndSetEnabledFlag(),
                    MakeNewOperationTypeInfo.FromScratch()
                                            .HavingOperationType(
                                                OperationType.RenameSubFolders
                                            )
                                            .AndSetEnabledFlag(),
                    MakeNewOperationTypeInfo.FromScratch()
                                            .HavingOperationType(
                                                OperationType.ReplaceTextInFiles
                                            )
                                            .AndSetEnabledFlag(),
                    MakeNewOperationTypeInfo.FromScratch()
                                            .HavingOperationType(
                                                OperationType.RenameSolutionFolders
                                            )
                                            .AndSetEnabledFlag(),
                };
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new List<IOperationTypeInfo>();
            }

            return result;
        }
    }
}