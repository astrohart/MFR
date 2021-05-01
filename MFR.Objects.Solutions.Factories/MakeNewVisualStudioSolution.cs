namespace MFR.Objects.Solutions.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the <see cref="T:EnvDTE.DTE" /> interface, and returns references to them.
    /// </summary>
    public static class MakeNewVisualStudioSolution
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see cref="T:EnvDTE.DTE" /> interface and returns a reference to it.
        /// </summary>
        /// <returns>Reference to an instance of an object that implements the <see cref="T:EnvDTE.DTE" /> interface.</returns>
        public static IVisualStudioSolution FromScratch()
            => new VisualStudioSolution();
    }
}