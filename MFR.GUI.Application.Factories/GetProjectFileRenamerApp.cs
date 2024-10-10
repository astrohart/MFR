using MFR.GUI.Application.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Application.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.GUI.Application.Interfaces.IWinApp" /> interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetProjectFileRenamerApp
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.GUI.Application.Interfaces.IWinApp" /> interface, and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.GUI.Application.Interfaces.IWinApp" /> interface.
        /// </returns>
        public static IWinApp SoleInstance()
            => ProjectFileRenamerApp.Instance;
    }
}