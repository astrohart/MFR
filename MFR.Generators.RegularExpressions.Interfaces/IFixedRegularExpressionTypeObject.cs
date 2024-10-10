using MFR.Generators.RegularExpressions.Constants;

namespace MFR.Generators.RegularExpressions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that processes only a certain type of regular expression.
    /// </summary>
    public interface IFixedRegularExpressionTypeObject
    {
        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Constants.RegularExpressionType" />
        /// value that uniquely identifies which type of regular expressions
        /// that this object handles.
        /// </summary>
        RegularExpressionType RegularExpressionType
        {
            get;
        }
    }
}