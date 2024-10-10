using xyLOGIX.Generators.Interfaces;

namespace MFR.Generators.RegularExpressions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that generates regular expressions of a given type.
    /// </summary>
    public interface IRegularExpressionGenerator : IGenerator<string, string>,
        IFixedRegularExpressionTypeObject 
    {
        // TODO: Add event, method, and property definitions here
    }
}