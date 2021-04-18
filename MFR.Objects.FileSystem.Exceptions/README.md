<a name='assembly'></a>
# MFR.Objects.FileSystem.Exceptions

## Contents

- [InvalidPathException](#T-MFR-Objects-FileSystem-Exceptions-InvalidPathException 'MFR.Objects.FileSystem.Exceptions.InvalidPathException')
  - [#ctor(message,path)](#M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String- 'MFR.Objects.FileSystem.Exceptions.InvalidPathException.#ctor(System.String,System.String)')
  - [#ctor(message,paramName,path)](#M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String,System-String- 'MFR.Objects.FileSystem.Exceptions.InvalidPathException.#ctor(System.String,System.String,System.String)')
  - [#ctor(message,path,innerException)](#M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String,System-Exception- 'MFR.Objects.FileSystem.Exceptions.InvalidPathException.#ctor(System.String,System.String,System.Exception)')
  - [#ctor(message,path,paramName,innerException)](#M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String,System-String,System-Exception- 'MFR.Objects.FileSystem.Exceptions.InvalidPathException.#ctor(System.String,System.String,System.String,System.Exception)')
  - [#ctor()](#M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor 'MFR.Objects.FileSystem.Exceptions.InvalidPathException.#ctor')
  - [Path](#P-MFR-Objects-FileSystem-Exceptions-InvalidPathException-Path 'MFR.Objects.FileSystem.Exceptions.InvalidPathException.Path')
- [Resources](#T-MFR-Objects-FileSystem-Exceptions-Properties-Resources 'MFR.Objects.FileSystem.Exceptions.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Exceptions-Properties-Resources-Culture 'MFR.Objects.FileSystem.Exceptions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Exceptions-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Exceptions.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Exceptions-InvalidPathException'></a>
## InvalidPathException `type`

##### Namespace

MFR.Objects.FileSystem.Exceptions

##### Summary

Class that encapsulates a custom type of exception that allows us to
tell the developer that a variable contains an invalid pathname, i.e., a
pathname that does not satisfy operating-system rules.

<a name='M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String-'></a>
### #ctor(message,path) `constructor`

##### Summary

Constructs a new instance of [InvalidPathException](#T-MFR-Objects-FileSystem-Exceptions-InvalidPathException 'MFR.Objects.FileSystem.Exceptions.InvalidPathException') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the pathname that ended up being found to be invalid. |

<a name='M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String,System-String-'></a>
### #ctor(message,paramName,path) `constructor`

##### Summary

Constructs a new instance of [InvalidPathException](#T-MFR-Objects-FileSystem-Exceptions-InvalidPathException 'MFR.Objects.FileSystem.Exceptions.InvalidPathException') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| paramName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the parameter that caused the current exception. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the pathname that ended up being found to be invalid. |

<a name='M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String,System-Exception-'></a>
### #ctor(message,path,innerException) `constructor`

##### Summary

Constructs a new instance of [InvalidPathException](#T-MFR-Objects-FileSystem-Exceptions-InvalidPathException 'MFR.Objects.FileSystem.Exceptions.InvalidPathException') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the pathname that ended up being found to be invalid. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. If the
`innerException` parameter is not a null reference,
the current exception is raised in a `catch` block
that handles the inner exception. |

<a name='M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor-System-String,System-String,System-String,System-Exception-'></a>
### #ctor(message,path,paramName,innerException) `constructor`

##### Summary

Constructs a new instance of [InvalidPathException](#T-MFR-Objects-FileSystem-Exceptions-InvalidPathException 'MFR.Objects.FileSystem.Exceptions.InvalidPathException') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the pathname that ended up being found to be invalid. |
| paramName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the parameter that caused the current exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. If the
`innerException` parameter is not a null reference,
the current exception is raised in a `catch` block
that handles the inner exception. |

<a name='M-MFR-Objects-FileSystem-Exceptions-InvalidPathException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [InvalidPathException](#T-MFR-Objects-FileSystem-Exceptions-InvalidPathException 'MFR.Objects.FileSystem.Exceptions.InvalidPathException') and returns
a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor overload is protected, meaning that callers of this
class are forced to use one of the other constructor overloads that
take parameters.

<a name='P-MFR-Objects-FileSystem-Exceptions-InvalidPathException-Path'></a>
### Path `property`

##### Summary

Gets a string containing the pathname that failed to meet operating
system rules.

<a name='T-MFR-Objects-FileSystem-Exceptions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Exceptions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Exceptions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Exceptions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
