﻿using MFR.Objects.Generators.RegularExpressions.Constants;
using MFR.Objects.Generators.RegularExpressions.Interfaces;
using System;

namespace MFR.Objects.Generators.RegularExpressions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the <see cref="T:MFR.Objects.Generators.RegularExpressions.Factories" /> interface.
    /// </summary>
    public static class GetRegularExpressionGenerator
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see cref="T:MFR.Objects.Generators.RegularExpressions.Factories" /> interface and returns a reference to it.
        /// </summary>
        public static IRegularExpressionGenerator For(RegularExpressionType type)
        {
            IRegularExpressionGenerator regularExpressionGenerator;

            switch (type)
            {
                case RegularExpressionType.MatchExactWordOnly:
                    regularExpressionGenerator =
                        MatchExactWordOnlyRegularExpressionGenerator.Instance;
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