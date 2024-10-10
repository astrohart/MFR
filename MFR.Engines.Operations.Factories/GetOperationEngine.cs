using MFR.Engines.Constants;
using MFR.Engines.Operations.Interfaces;
using System;

namespace MFR.Engines.Operations.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see cref="T:MFR.Engines.Interfaces.IOperationEngine" /> interface.
    /// </summary>
    public static class GetOperationEngine
    {
        /// <summary>
        /// Creates an instance of an object implementing the
        /// <see cref="T:MFR.Engines.Interfaces.IOperationEngine" /> interface which
        /// corresponds to the value specified in <paramref name="type" />, and returns a
        /// reference to it.
        /// </summary>
        /// <param name="type">
        /// One of the
        /// <see cref="T:MFR.Engines.Constants.OperationEngineType" /> values that
        /// describes what type of object you want.
        /// </param>
        /// <typeparam name="T">
        /// Name of any interface that implements
        /// <see cref="T:MFR.Engines.Interfaces.IOperationEngine" /> to which the returned
        /// object should be cast.
        /// <para />
        /// Obviously, the object that is being returned should also implement the
        /// interface that you are specifying in this type parameter.
        /// </typeparam>
        /// <returns>
        /// A reference to the instance of the object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IOperationEngine" /> interface which
        /// corresponds to the value specified in <paramref name="type" />.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types implemented
        /// that correspond to the value of <paramref name="type" />.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no
        /// corresponding concrete type defined that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IOperationEngine" /> interface and which
        /// corresponds to the value passed in the <paramref name="type" /> parameter.
        /// </exception>
        public static T OfType<T>(OperationEngineType type)
            where T : class, IOperationEngine
        {
            IOperationEngine result;

            switch (type)
            {
                case OperationEngineType.FullGUI:
                    result = GetFullGuiOperationEngine.SoleInstance() as T;
                    break;

                case OperationEngineType.Console:
                    result = GetConsoleOperationEngine.SoleInstance() as T;
                    break;

                case OperationEngineType.Unknown:
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"The operation engine type '{type}' is not supported."
                    );
            }

            return (T)result;
        }
    }
}