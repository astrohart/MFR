<a name='assembly'></a>
# MFR.Objects.Filters.Search

## Contents

- [Resources](#T-MFR-Objects-Filters-Search-Properties-Resources 'MFR.Objects.Filters.Search.Properties.Resources')
  - [Culture](#P-MFR-Objects-Filters-Search-Properties-Resources-Culture 'MFR.Objects.Filters.Search.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Filters-Search-Properties-Resources-ResourceManager 'MFR.Objects.Filters.Search.Properties.Resources.ResourceManager')
- [SearchFilterItemBase](#T-MFR-Objects-Filters-Search-SearchFilterItemBase 'MFR.Objects.Filters.Search.SearchFilterItemBase')
  - [#ctor(descriptor)](#M-MFR-Objects-Filters-Search-SearchFilterItemBase-#ctor-System-String- 'MFR.Objects.Filters.Search.SearchFilterItemBase.#ctor(System.String)')
  - [Descriptor](#P-MFR-Objects-Filters-Search-SearchFilterItemBase-Descriptor 'MFR.Objects.Filters.Search.SearchFilterItemBase.Descriptor')
  - [IsExclusion](#P-MFR-Objects-Filters-Search-SearchFilterItemBase-IsExclusion 'MFR.Objects.Filters.Search.SearchFilterItemBase.IsExclusion')
  - [Type](#P-MFR-Objects-Filters-Search-SearchFilterItemBase-Type 'MFR.Objects.Filters.Search.SearchFilterItemBase.Type')

<a name='T-MFR-Objects-Filters-Search-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Filters.Search.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Filters-Search-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Filters-Search-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Filters-Search-SearchFilterItemBase'></a>
## SearchFilterItemBase `type`

##### Namespace

MFR.Objects.Filters.Search

##### Summary

Provides a common implementation for all search filters objects.

<a name='M-MFR-Objects-Filters-Search-SearchFilterItemBase-#ctor-System-String-'></a>
### #ctor(descriptor) `constructor`

##### Summary

Constructs a new instance of [SearchFilter](#T-MFR-Objects-SearchFilter 'MFR.Objects.SearchFilter') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| descriptor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A glob pattern, or a file or folder pathname that
describes how to search for items. |

<a name='P-MFR-Objects-Filters-Search-SearchFilterItemBase-Descriptor'></a>
### Descriptor `property`

##### Summary

Gets a string that describes this search filter item (i.e., a glob
pattern match, or a path to a folder or specific file).

<a name='P-MFR-Objects-Filters-Search-SearchFilterItemBase-IsExclusion'></a>
### IsExclusion `property`

##### Summary

Gets a value indicating whether this is an Exclusion or an Inclusion filter.

<a name='P-MFR-Objects-Filters-Search-SearchFilterItemBase-Type'></a>
### Type `property`

##### Summary

Gets the type of filter that this is
