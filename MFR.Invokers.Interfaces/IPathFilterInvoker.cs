using System;

namespace MFR.Invokers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of all path filter invoker objects.
    /// </summary>
    public interface IPathFilterInvoker
    {
        /// <summary>
        /// Fluent-builder method that set the path that the path-filtering
        /// predicate is to be invoked upon.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IPathFilterInvoker AndPath(string path);

        /// <summary>
        /// Gets the result of invoking the path-filtering predicate on the path
        /// specified by calling the <see
        /// cref="M:MFR.IPathFilterInvoker.AndPath"/> method.
        /// </summary>
        /// <param name="pathFilter">
        /// A <see cref="T:System.Predicate"/>, taking a string as argument,
        /// that decides whether the path should be allowed.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the path passed to the predicate is to be
        /// allowed in the operation; <see langword="false"/> otherwise. This
        /// method also returns <see langword="true"/> if the <paramref
        /// name="pathFilter"/> is passed a <see langword="null"/> reference.
        /// </returns>
        bool Passes(Predicate<string> pathFilter);
    }
}