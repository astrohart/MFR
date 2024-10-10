using MFR.Generators.RegularExpressions.Constants;
using MFR.Generators.RegularExpressions.Interfaces;
using System;

namespace MFR.Generators.RegularExpressions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
    /// interface.
    /// </summary>
    public static class GetRegularExpressionGenerator
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Constants.RegularExpressionType" />
        /// values that specifies the type of regular expression that you want
        /// to generate.
        /// </param>
        public static IRegularExpressionGenerator For(
            RegularExpressionType type)
        {
            IRegularExpressionGenerator regularExpressionGenerator;

            switch (type)
            {
                case RegularExpressionType.MatchExactWordOnly:
                    regularExpressionGenerator =
                        MatchExactWordOnlyRegularExpressionGenerator.Instance;
                    break;

                case RegularExpressionType.MatchWholeLine:
                    regularExpressionGenerator =
                        MatchWholeLineRegularExpressionGenerator.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no object available that corresponds to the type '{type}'."
                    );
            }

            return regularExpressionGenerator;
        }
    }
}