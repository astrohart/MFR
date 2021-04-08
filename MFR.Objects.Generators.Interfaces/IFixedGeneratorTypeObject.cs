using MFR.Objects.Generators.Constants;

namespace MFR.Objects.Generators.Interfaces
{
    /// <summary>
    /// Object that provides functionality for a particular
    /// <see
    ///     cref="T:MFR.Objects.Generators.Constants.GeneratorType" />
    /// value.
    /// </summary>
    public interface IFixedGeneratorTypeObject
    {
        /// <summary>
        /// A <see cref="T:MFR.Objects.Generators.Constants.GeneratorType" />
        /// value that specifies which type of generator this object is.
        /// </summary>
        GeneratorType GeneratorType
        {
            get;
        }
    }
}