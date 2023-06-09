using MFR.GUI.Models.Interfaces;
using MFR.Settings.Configuration.Converters.Interfaces;

namespace MFR.Settings.Configuration.Converters.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter" />
    /// interface and returns references to them.
    /// </summary>
    public class MakeNewOperationTypeInfoConverter
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Fully-qualified name of the
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> model class that should be
        /// wrapped by the converter object.
        /// </typeparam>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter" />
        /// interface for the model class specified in the
        /// <typeparamref name="T" /> generic parameter.
        /// </returns>
        public static IOperationTypeInfoConverter FromScratch<T>()
            where T : IOperationTypeInfo
            => new OperationTypeInfoConverter<T>();
    }
}