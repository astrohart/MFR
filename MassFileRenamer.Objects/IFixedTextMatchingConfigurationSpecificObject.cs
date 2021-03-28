using PostSharp.Patterns.Diagnostics;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// tagged with one of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
    /// values.
    /// </summary>
    /// <remarks>
    /// This interface represents an object for which the operation type is immutable.
    /// </remarks>
    public interface IFixedTextMatchingConfigurationSpecificObject
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)] TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        }
    }
}