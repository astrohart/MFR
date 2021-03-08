using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master configuration file.
    /// </summary>
    public class
        LoadStringFromRegistryAction : ActionBase<IRegQueryExpression<string>
            , IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadStringFromRegistryAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadStringFromRegistryAction() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.LoadStringFromRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static LoadStringFromRegistryAction Instance
        {
            get;
        } = new LoadStringFromRegistryAction();

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MessageType" />
        /// that is
        /// being used to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => MessageType.LoadStringFromRegistry;

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// String containing the path to the master configuration file loaded
        /// from the system Registry, or blank if an error occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.ActionBase._input" />
        /// field is blank or <c>null</c>.
        /// </exception>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IFileSystemEntry CommonExecute()
        {
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input field has a null reference for a value..."
            );

            IFileSystemEntry result = null;

            // Check to see if the required field, _input, is null. If it is, send an 
            // error to the log file and quit.
            if (_input == null)
            {
                // the field _input is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input field has a null reference.  This field is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug, "LoadStringFromRegistryAction.Execute: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input field has a valid object reference for its value."
            );

            try
            {
                result = MakeNewFileSystemEntry.ForPath(
                    SystemPreparer.GetRegistryString(
                        _input.KeyPath, _input.ValueName, _input.DefaultValue
                    ).Replace("\"", string.Empty)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }
    }
}