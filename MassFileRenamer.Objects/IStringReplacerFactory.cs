namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a String Replacer object.
    /// </summary>
    public interface IStringReplacerFactory : IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see
        /// cref="T:MassFileRenamer.Objects.IStringReplacer"/> interface and
        /// returns a reference to it for the <see
        /// cref="T:MassFileRenamer.Objects.MatchingConfiguration"/> value that
        /// is specified by the <paramref name="matchingConfig"/> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the <see
        /// cref="T:MassFileRenamer.Objects.MatchingConfiguration"/> values that
        /// specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MassFileRenamer.Objects.IStringReplacer"/> interface.
        /// </returns>
        IStringReplacer AndMatchingConfiguration(
            MatchingConfiguration matchingConfig);
    }
}