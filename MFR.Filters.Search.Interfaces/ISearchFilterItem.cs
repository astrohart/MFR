using MFR.Filters.Search.Constants;

namespace MFR.Filters.Search.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a search filter
    /// item object.
    /// </summary>
    public interface ISearchFilterItem
    {
        /// <summary>
        /// Gets a string that describes this search filter item (i.e., a glob
        /// pattern match, or a path to a folder or specific file).
        /// </summary>
        string Descriptor
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this an Exclusion or an Inclusion filter.
        /// </summary>
        bool IsExclusion
        {
            get;
        }

        /// <summary>
        /// Gets the type of filter that this
        /// </summary>
        SearchFilterType Type
        {
            get;
        }
    }
}
