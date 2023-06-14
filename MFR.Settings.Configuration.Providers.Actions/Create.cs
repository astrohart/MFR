using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;
using Initialize = MFR.GUI.Models.Actions.Initialize;

namespace MFR.Settings.Configuration.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to create instances of objects and data.
    /// </summary>
    public static class Create
    {
        /// <summary>
        /// Creates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface and initializes it with the default invokable operations.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that is initialized with the default invokable operations.
        /// </returns>
        public static IProjectFileRenamerConfiguration BlankConfiguration()
        {
            IProjectFileRenamerConfiguration result = default;

            try
            {
                result = MakeNewProjectFileRenamerConfiguration.FromScratch()
                    .HavingInvokableOperations(Initialize.OperationList());
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}