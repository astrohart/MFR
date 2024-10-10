using MFR.GUI.Windows.Wrappers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Windows.Wrappers.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Windows.Wrappers.Interfaces" /> interface, and returns
    /// references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewWindowWrapper
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Windows.Wrappers.Interfaces" /> interface and returns a
        /// reference to it.
        /// </summary>
        public static IWindowWrapper FromScratch()
            => new WindowWrapper();
    }
}