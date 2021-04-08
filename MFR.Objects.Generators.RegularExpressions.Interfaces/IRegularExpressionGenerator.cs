using MFR.Objects.Generators.Interfaces;

namespace MFR.Objects.Generators.RegularExpressions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that generates regular expressions of a given type.
    /// </summary>
    public interface IRegularExpressionGenerator : IGenerator<string, string>,
        IFixedRegularExpressionTypeObject {
    }
}