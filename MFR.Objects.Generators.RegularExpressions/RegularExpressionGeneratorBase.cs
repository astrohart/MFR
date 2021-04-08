using MFR.Objects.Generators.Constants;
using MFR.Objects.Generators.RegularExpressions.Constants;
using MFR.Objects.Generators.RegularExpressions.Interfaces;

namespace MFR.Objects.Generators.RegularExpressions
{
    /// <summary>
    /// Defines the services that are available to all of the concrete
    /// implementations of
    /// </summary>
    public abstract class
        RegularExpressionGeneratorBase : GeneratorBase<string, string>,
            IRegularExpressionGenerator
    {
        /// <summary>
        /// A <see cref="T:MFR.Objects.Generators.Constants.GeneratorType" />
        /// value that specifies which type of generator this object is.
        /// </summary>
        public override GeneratorType GeneratorType
            => GeneratorType.RegularExpression;

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.Objects.Generators.RegularExpressions.Constants.RegularExpressionType" />
        /// value that uniquely identifies which type of regular expressions
        /// that this object handles.
        /// </summary>
        public abstract RegularExpressionType RegularExpressionType
        {
            get;
        }
    }
}