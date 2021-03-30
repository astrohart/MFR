using System;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Interop
{
    /// <summary>
    /// Looks up running objects from the operating-system-provided Running
    /// Object Table (ROT) on the local workstation.
    /// </summary>efs
    public class GetRunningOperatingSystemObject
    {
        /// <summary>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:System.Runtime.InteropServices.ComTypes.IMoniker"/> interface.
        /// </summary>
        private IMoniker _moniker;

        /// <summary>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable"/> interface.
        /// </summary>
        private IRunningObjectTable _runningObjectTable;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GetRunningOperatingSystemObject()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GetRunningOperatingSystemObject()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Objects.Interop.GetRunningOperatingSystemObject"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static GetRunningOperatingSystemObject Instance
        {
            get;
        } = new GetRunningOperatingSystemObject();

        /// <summary>
        /// Associates this object with an instance of an
        /// operating-system-provided object that implements the <see
        /// cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable"/> interface.
        /// <para/>
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public object AndRunningObjectTable(
            IRunningObjectTable runningObjectTable)
        {
            _runningObjectTable = runningObjectTable ??
                                  throw new ArgumentNullException(
                                      nameof(runningObjectTable)
                                  );

            if (_moniker == null)
                throw new InvalidOperationException(
                    "You must call the FromMoniker method prior to calling this one."
                );

            object result;

            try
            {
                _runningObjectTable.GetObject(_moniker, out result);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Associates a reference to an instance of an
        /// operating-system-provided object that implements the <see
        /// cref="T:System.Runtime.InteropServices.ComTypes.IMoniker"/>
        /// interface with this factory.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="moniker"/>, is
        /// passed a <see langword="null"/> value.
        /// </exception>
        public GetRunningOperatingSystemObject FromMoniker(IMoniker moniker)
        {
            _moniker = moniker;

            return this;
        }
    }
}