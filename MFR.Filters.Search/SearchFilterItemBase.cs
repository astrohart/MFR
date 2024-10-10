using MFR.Filters.Search.Constants;
using MFR.Filters.Search.Interfaces;
using System;

namespace MFR.Filters.Search
{
    /// <summary>
    /// Provides a common implementation for all search filters objects.
    /// </summary>
    public abstract class SearchFilterItemBase : ISearchFilterItem
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.SearchFilter"/> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="descriptor">
        /// (Required.) A glob pattern, or a file or folder pathname that
        /// describes how to search for items.
        /// </param>
        protected SearchFilterItemBase(string descriptor)
        {
            if (string.IsNullOrWhiteSpace(descriptor))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(descriptor)
                );
            Descriptor = descriptor;
        }

        /// <summary>
        /// Gets a string that describes this search filter item (i.e., a glob
        /// pattern match, or a path to a folder or specific file).
        /// </summary>
        public string Descriptor
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this an Exclusion or an Inclusion filter.
        /// </summary>
        public abstract bool IsExclusion
        {
            get;
        }

        /// <summary>
        /// Gets the type of filter that this
        /// </summary>
        public abstract SearchFilterType Type
        {
            get;
        }
    }
}