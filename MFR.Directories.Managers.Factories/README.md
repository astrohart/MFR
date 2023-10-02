<a name='assembly'></a>
# MFR.Directories.Managers.Factories

## Contents

- [GetSearchDirectoryManager](#T-MFR-Directories-Managers-Factories-GetSearchDirectoryManager 'MFR.Directories.Managers.Factories.GetSearchDirectoryManager')
  - [SoleInstance()](#M-MFR-Directories-Managers-Factories-GetSearchDirectoryManager-SoleInstance 'MFR.Directories.Managers.Factories.GetSearchDirectoryManager.SoleInstance')
- [Resources](#T-MFR-Directories-Managers-Factories-Properties-Resources 'MFR.Directories.Managers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Directories-Managers-Factories-Properties-Resources-Culture 'MFR.Directories.Managers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Managers-Factories-Properties-Resources-ResourceManager 'MFR.Directories.Managers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Managers-Factories-GetSearchDirectoryManager'></a>
## GetSearchDirectoryManager `type`

##### Namespace

MFR.Directories.Managers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
interface.

<a name='M-MFR-Directories-Managers-Factories-GetSearchDirectoryManager-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Directories-Managers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Managers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Managers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Managers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
