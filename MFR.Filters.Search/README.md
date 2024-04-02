<a name='assembly'></a>
# MFR.Filters.Search

## Contents

- [Resources](#T-MFR-Filters-Search-Properties-Resources 'MFR.Filters.Search.Properties.Resources')
  - [Culture](#P-MFR-Filters-Search-Properties-Resources-Culture 'MFR.Filters.Search.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Filters-Search-Properties-Resources-ResourceManager 'MFR.Filters.Search.Properties.Resources.ResourceManager')
- [SearchFilterItemBase](#T-MFR-Filters-Search-SearchFilterItemBase 'MFR.Filters.Search.SearchFilterItemBase')
  - [#ctor(descriptor)](#M-MFR-Filters-Search-SearchFilterItemBase-#ctor-System-String- 'MFR.Filters.Search.SearchFilterItemBase.#ctor(System.String)')
  - [Descriptor](#P-MFR-Filters-Search-SearchFilterItemBase-Descriptor 'MFR.Filters.Search.SearchFilterItemBase.Descriptor')
  - [IsExclusion](#P-MFR-Filters-Search-SearchFilterItemBase-IsExclusion 'MFR.Filters.Search.SearchFilterItemBase.IsExclusion')
  - [Type](#P-MFR-Filters-Search-SearchFilterItemBase-Type 'MFR.Filters.Search.SearchFilterItemBase.Type')

<a name='T-MFR-Filters-Search-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Filters.Search.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Filters-Search-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Filters-Search-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Filters-Search-SearchFilterItemBase'></a>
## SearchFilterItemBase `type`

##### Namespace

MFR.Filters.Search

##### Summary

Provides a common implementation for all search filters objects.

<a name='M-MFR-Filters-Search-SearchFilterItemBase-#ctor-System-String-'></a>
### #ctor(descriptor) `constructor`

##### Summary

Constructs a new instance of [SearchFilter](#T-MFR-SearchFilter 'MFR.SearchFilter') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| descriptor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A glob pattern, or a file or folder pathname that
describes how to search for items. |

<a name='P-MFR-Filters-Search-SearchFilterItemBase-Descriptor'></a>
### Descriptor `property`

##### Summary

Gets a string that describes this search filter item (i.e., a glob
pattern match, or a path to a folder or specific file).

<a name='P-MFR-Filters-Search-SearchFilterItemBase-IsExclusion'></a>
### IsExclusion `property`

##### Summary

Gets a value indicating whether this an Exclusion or an Inclusion filter.

<a name='P-MFR-Filters-Search-SearchFilterItemBase-Type'></a>
### Type `property`

##### Summary

Gets the type of filter that this
