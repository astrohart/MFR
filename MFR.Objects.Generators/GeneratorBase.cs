using MFR.Objects.Generators.Constants;
using MFR.Objects.Generators.Interfaces;

namespace MFR.Objects.Generators
{
    /// <summary>
    /// Defines the events, methods, and properties that can be used by all
    /// concrete <c>Generator</c> object implementations.
    /// </summary>
    /// <typeparam name="TInput">
    /// Name of the type of the input value.
    /// </typeparam>
    /// <typeparam name="TOutput">
    /// Name of the type of the output value.
    /// </typeparam>
    public abstract class
        GeneratorBase<TInput, TOutput> : IGenerator<TInput, TOutput>
    {
        /// <summary>
        /// A <see cref="T:MFR.Objects.Generators.Constants.GeneratorType" />
        /// value that specifies which type of generator this object is.
        /// </summary>
        public abstract GeneratorType GeneratorType
        {
            get;
        }

        /// <summary>
        /// Transforms the input <paramref name="value" /> into the output value.
        /// </summary>
        /// <param name="value">
        /// Reference to an instance of <typeparamref name="TInput" /> that is
        /// the value to be transformed.
        /// </param>
        /// <returns>
        /// A <typeparamref name="TOutput" /> whose value is the result of the
        /// transformation.
        /// </returns>
        public abstract TOutput Generate(TInput value);
    }
}