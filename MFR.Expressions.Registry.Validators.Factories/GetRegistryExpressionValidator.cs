using MFR.Expressions.Registry.Validators.Interfaces;

namespace MFR.Expressions.Registry.Validators.Factories
{
    /// <summary>
    /// Accesses the sole instance of an object that implements the
    /// <see
    ///     cref="T:MFR.IRegQueryExpressionValidator" />
    /// interface.
    /// </summary>
    /// <typeparam name="T">
    /// Name of the type of the data that is to be retrieved from the system Registry.
    /// </typeparam>
    public static class GetRegistryExpressionValidator<T> where T : class
    {
        /// <summary>
        /// Fluently retrieves the single instance of the object that implements
        /// the
        /// <see
        ///     cref="T:MFR.IRegQueryExpressionValidator" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IRegQueryExpressionValidator" />
        /// interface.
        /// </returns>
        public static IRegQueryExpressionValidator<T> SoleInstance()
            => RegQueryExpressionValidator<T>.Instance;
    }
}