using MFR.Engines.Operations.Jobs.Interfaces;
using System;

namespace MFR.Engines.Operations.Jobs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob" />
    /// interface, and returns references to them.
    /// </summary>
    public static class MakeNewFileRenamerJob
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.ReplaceWith" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob" />
        /// interface.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) A <see cref="T:System.String" /> that contains the replacement
        /// text.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFileRenamerJob AndReplaceItWith(
            this IFileRenamerJob self,
            string replaceWith
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceWith = replaceWith;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob" />
        /// interface.
        /// </returns>
        public static IFileRenamerJob ForRootDirectory(string pathname)
            => new FileRenamerJob { RootDirectory = pathname };

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Engines.Operations.Models.Interfaces.IFileRenamerJob.PathFilter" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Engines.Operations.Models.Interfaces.IFileRenamerJob" />
        /// interface.
        /// </param>
        /// <param name="pathFilter">
        /// (Required.) A <see cref="T:System.Predicate{System.String}" /> that represents
        /// the criteria to be used in the search.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFileRenamerJob HavingPathFilter(
            this IFileRenamerJob self,
            Predicate<string> pathFilter
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.PathFilter = pathFilter;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.FindWhat" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob" />
        /// interface.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) A <see cref="T:System.String" /> that contains the text to be
        /// searched for.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFileRenamerJob ToFindWhat(
            this IFileRenamerJob self,
            string findWhat
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FindWhat = findWhat;
            return self;
        }
    }
}