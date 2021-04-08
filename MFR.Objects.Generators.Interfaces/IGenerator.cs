namespace MFR.Objects.Generators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// accepts inputs and transforms them into other values.
    /// </summary>
    /// <typeparam name="TInput">
    /// Name of the type that is provided as input to the generator.
    /// </typeparam>
    /// <typeparam name="TOutput">Name of the type of the output value.</typeparam>
    /// <remarks>
    /// A <c>Generator</c> object is very much akin to a <c>Translator</c>
    /// object; however where they differ is that a <c>Translator</c> may
    /// express a one-to-one mapping from an input object's members to an output
    /// object's members; a <c>Generator</c> object may instead transform one
    /// <i>value</i> directly into another <i>value</i>.
    /// </remarks>
    public interface
        IGenerator<in TInput, out TOutput> : IFixedGeneratorTypeObject
    {
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
        TOutput Generate(TInput value);
    }
}