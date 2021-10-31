<a name='assembly'></a>
# MFR.Operations.Exceptions

## Contents

- [OperationAbortedException](#T-MFR-Objects-Operations-Exceptions-OperationAbortedException 'MFR.Operations.Exceptions.OperationAbortedException')
  - [#ctor(message)](#M-MFR-Objects-Operations-Exceptions-OperationAbortedException-#ctor-System-String- 'MFR.Operations.Exceptions.OperationAbortedException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-MFR-Objects-Operations-Exceptions-OperationAbortedException-#ctor-System-String,System-Exception- 'MFR.Operations.Exceptions.OperationAbortedException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-MFR-Objects-Operations-Exceptions-OperationAbortedException-#ctor 'MFR.Operations.Exceptions.OperationAbortedException.#ctor')
- [Resources](#T-MFR-Objects-Operations-Exceptions-Properties-Resources 'MFR.Operations.Exceptions.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Exceptions-Properties-Resources-Culture 'MFR.Operations.Exceptions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Exceptions-Properties-Resources-ResourceManager 'MFR.Operations.Exceptions.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-Exceptions-OperationAbortedException'></a>
## OperationAbortedException `type`

##### Namespace

MFR.Operations.Exceptions

##### Summary

Signals that a request has been made to abort an operation.

<a name='M-MFR-Objects-Operations-Exceptions-OperationAbortedException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Constructs a new instance of [OperationAbortedException](#T-MFR-Objects-Operations-Exceptions-OperationAbortedException 'MFR.Operations.Exceptions.OperationAbortedException') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The error message that explains the reason for the exception. |

<a name='M-MFR-Objects-Operations-Exceptions-OperationAbortedException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Constructs a new instance of [OperationAbortedException](#T-MFR-Objects-Operations-Exceptions-OperationAbortedException 'MFR.Operations.Exceptions.OperationAbortedException') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The error message that explains the reason for the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception, or a null reference. |

<a name='M-MFR-Objects-Operations-Exceptions-OperationAbortedException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [OperationAbortedException](#T-MFR-Objects-Operations-Exceptions-OperationAbortedException 'MFR.Operations.Exceptions.OperationAbortedException') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='T-MFR-Objects-Operations-Exceptions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Exceptions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Exceptions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Exceptions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
