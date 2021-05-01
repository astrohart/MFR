using EnvDTE;
using System;

namespace MFR.Objects.Solutions
{
    /// <summary>
    /// Encapsulates the data and actions that are applicable to a Visual Studio
    /// Solution (*.sln) file.
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// interface.
        /// </summary>
        private DTE _dte;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Solutions.Solution" />
        /// and returns a reference to it.
        /// </summary>
        public Solution()
        {
            _dte = null;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Solutions.Solution" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dte" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        public Solution(DTE dte)
        {
            _dte = dte ?? throw new ArgumentNullException(nameof(dte));
        }

        /// <summary>
        /// Initializes this object with a reference to an instance of an object
        /// that implements the <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dte" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        /// <remarks>
        /// <b>NOTE:</b> Only call this method if you've used the default
        /// constructor to instantiate this object.
        /// </remarks>
        public void Initialize(DTE dte)
            => _dte = dte ?? throw new ArgumentNullException(nameof(dte));
    }
}