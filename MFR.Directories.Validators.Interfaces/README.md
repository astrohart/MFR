<a name='assembly'></a>
# MFR.Directories.Validators.Interfaces

## Contents

- [IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
  - [Validate(rootDirectory)](#M-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator-Validate-System-String- 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator.Validate(System.String)')
- [Resources](#T-MFR-Directories-Validators-Interfaces-Properties-Resources 'MFR.Directories.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Interfaces-Properties-Resources-Culture 'MFR.Directories.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator'></a>
## IRootDirectoryPathValidator `type`

##### Namespace

MFR.Directories.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
validates the pathnames of root directories; i.e., the folder where the
project-rename operation starts..

<a name='M-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator-Validate-System-String-'></a>
### Validate(rootDirectory) `method`

##### Summary

Gets a value that determines whether the specified
`rootDirectory`
is valid or not.



A "root directory" is defined to be the starting folder of a
project-rename operation.



It must exist on the file system, and it must contain a Visual Studio
Solution (*.sln) file.

##### Returns

`true` if the pathname specified by the
`rootDirectory`
parameter refers to a valid directory;
`false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname of a root directory to be validated. |

##### Remarks

In the event that validation fails, this method raises the
[](#E-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator-RootDirectoryInvalid 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid')
event.

<a name='T-MFR-Directories-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
