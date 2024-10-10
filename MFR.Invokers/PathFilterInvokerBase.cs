using MFR.Invokers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Invokers
{
    /// <summary>
    /// Provides common functionality for all path filter invoker objects.
    /// </summary>
    public class PathFilterInvokerBase : IPathFilterInvoker
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Invokers.PathFilterInvokerBase"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static PathFilterInvokerBase Instance
        {
            get;
        } = new PathFilterInvokerBase();

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static PathFilterInvokerBase() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected PathFilterInvokerBase() { }

        /// <summary>
        /// Gets or sets a string that contains the path to be decided upon.
        /// </summary>
        private string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Fluent-builder method that set the path that the path-filtering
        /// predicate is to be invoked upon.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public IPathFilterInvoker AndPath(string path)
        {
            Path = path;

            return this;
        }

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
        public bool Passes(Predicate<string> pathFilter)
            => pathFilter == null || pathFilter(Path);
    }
}