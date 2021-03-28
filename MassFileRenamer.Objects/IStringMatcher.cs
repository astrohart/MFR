namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that performs matching on strings.
    /// </summary>
    public interface IStringMatcher :
        IFixedTextMatchingConfigurationSpecificObject,
        IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Carries out the matching operation using the values
        /// specified by the provided <paramref name="expression" />.
        /// Returns a string
        /// </summary>
        /// <param name="source">
        /// (Required.)
        /// String containing the data upon which the matching
        /// operation is to be carried out.
        /// </param>
        /// <param
        ///     name="pattern">
        /// (Required.) String containing the pattern that
        /// allows us to match the data to be replaced.
        /// </param>
        /// <param
        ///     name="dest">
        /// (Optional.) Default is blank. String containing
        /// the new data that should be substituted for the replaced text.
        /// </param>
        /// <returns> String containing the new data. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either
        /// of the required parameters, <paramref name="source" /> ,
        /// <paramref name="pattern" />, or <paramref name="dest" /> , are
        /// passed blank or <see langword="null" /> string for values.
        /// </exception>
        string Replace(string source, string pattern, string dest = "");
    }
}