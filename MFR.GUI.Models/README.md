<a name='assembly'></a>
# MFR.GUI.Models

## Contents

- [ErrantProcessInfo](#T-MFR-GUI-Models-ErrantProcessInfo 'MFR.GUI.Models.ErrantProcessInfo')
  - [#ctor(pathname)](#M-MFR-GUI-Models-ErrantProcessInfo-#ctor-System-String- 'MFR.GUI.Models.ErrantProcessInfo.#ctor(System.String)')
  - [FileName](#P-MFR-GUI-Models-ErrantProcessInfo-FileName 'MFR.GUI.Models.ErrantProcessInfo.FileName')
  - [Pathname](#P-MFR-GUI-Models-ErrantProcessInfo-Pathname 'MFR.GUI.Models.ErrantProcessInfo.Pathname')
  - [ToString()](#M-MFR-GUI-Models-ErrantProcessInfo-ToString 'MFR.GUI.Models.ErrantProcessInfo.ToString')
- [OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo')
  - [_name](#F-MFR-GUI-Models-OperationTypeInfo-_name 'MFR.GUI.Models.OperationTypeInfo._name')
  - [_operationType](#F-MFR-GUI-Models-OperationTypeInfo-_operationType 'MFR.GUI.Models.OperationTypeInfo._operationType')
  - [Enabled](#P-MFR-GUI-Models-OperationTypeInfo-Enabled 'MFR.GUI.Models.OperationTypeInfo.Enabled')
  - [Name](#P-MFR-GUI-Models-OperationTypeInfo-Name 'MFR.GUI.Models.OperationTypeInfo.Name')
  - [OperationType](#P-MFR-GUI-Models-OperationTypeInfo-OperationType 'MFR.GUI.Models.OperationTypeInfo.OperationType')
  - [Equals(obj)](#M-MFR-GUI-Models-OperationTypeInfo-Equals-System-Object- 'MFR.GUI.Models.OperationTypeInfo.Equals(System.Object)')
  - [GetHashCode()](#M-MFR-GUI-Models-OperationTypeInfo-GetHashCode 'MFR.GUI.Models.OperationTypeInfo.GetHashCode')
  - [OnEnabledChanged()](#M-MFR-GUI-Models-OperationTypeInfo-OnEnabledChanged 'MFR.GUI.Models.OperationTypeInfo.OnEnabledChanged')
  - [OnNameChanged()](#M-MFR-GUI-Models-OperationTypeInfo-OnNameChanged 'MFR.GUI.Models.OperationTypeInfo.OnNameChanged')
  - [OnOperationTypeChanged()](#M-MFR-GUI-Models-OperationTypeInfo-OnOperationTypeChanged 'MFR.GUI.Models.OperationTypeInfo.OnOperationTypeChanged')
  - [ToString()](#M-MFR-GUI-Models-OperationTypeInfo-ToString 'MFR.GUI.Models.OperationTypeInfo.ToString')
- [Resources](#T-MFR-GUI-Models-Properties-Resources 'MFR.GUI.Models.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Properties-Resources-Culture 'MFR.GUI.Models.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Properties-Resources-ResourceManager 'MFR.GUI.Models.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-ErrantProcessInfo'></a>
## ErrantProcessInfo `type`

##### Namespace

MFR.GUI.Models

##### Summary

Encapsulates data about an errant process that is to be forcibly terminated
prior to the processing of either of the `Rename Files In Folder` or
`Rename Sub Folder(s)` operations.

<a name='M-MFR-GUI-Models-ErrantProcessInfo-#ctor-System-String-'></a>
### #ctor(pathname) `constructor`

##### Summary

Constructs a new instance of [ErrantProcessInfo](#T-MFR-GUI-Models-ErrantProcessInfo 'MFR.GUI.Models.ErrantProcessInfo')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `.exe` file representing a process that is to be forcibly
terminated. |

<a name='P-MFR-GUI-Models-ErrantProcessInfo-FileName'></a>
### FileName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing just the filename only, of the
`.exe` file representing a process that is to be forcibly terminated.

<a name='P-MFR-GUI-Models-ErrantProcessInfo-Pathname'></a>
### Pathname `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `.exe` file that is to be forcibly terminated.

<a name='M-MFR-GUI-Models-ErrantProcessInfo-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Models-OperationTypeInfo'></a>
## OperationTypeInfo `type`

##### Namespace

MFR.GUI.Models

##### Summary

Information about a type of operation to perform to indicate whether the user
wants to perform the operation.



Provides a model for a particular item in the CheckedListBox in the Operations
tab of the GUI.

<a name='F-MFR-GUI-Models-OperationTypeInfo-_name'></a>
### _name `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user -friendly name to display
for this operation type information object.

<a name='F-MFR-GUI-Models-OperationTypeInfo-_operationType'></a>
### _operationType `constants`

##### Summary

One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
corresponds to the type of operation to perform.

<a name='P-MFR-GUI-Models-OperationTypeInfo-Enabled'></a>
### Enabled `property`

##### Summary

Gets or sets a value that indicates whether the user wants to perform the
operation.

##### Returns

`true` if this operation is allowed by the user to be
performed; `false` otherwise.

##### Remarks

This property raises the
[](#E-MFR-GUI-Models-OperationTypeInfo-EnabledChanged 'MFR.GUI.Models.OperationTypeInfo.EnabledChanged') event when its
value is updated.

<a name='P-MFR-GUI-Models-OperationTypeInfo-Name'></a>
### Name `property`

##### Summary

Gets or sets the name of the operation type.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly display
name for the type of operation that this object represents.

##### Remarks

This property raises the
[](#E-MFR-GUI-Models-OperationTypeInfo-NameChanged 'MFR.GUI.Models.OperationTypeInfo.NameChanged') event when its
value is updated.

<a name='P-MFR-GUI-Models-OperationTypeInfo-OperationType'></a>
### OperationType `property`

##### Summary

Gets or sets the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') value
that corresponds to the type of operation to perform.

##### Returns

One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration values that indicates to what type of operation this object
corresponds.

##### Remarks

Setting the value of this property also updates the value of the
[Name](#P-MFR-GUI-Models-OperationTypeInfo-Name 'MFR.GUI.Models.OperationTypeInfo.Name') property in order to
correspond to the new [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration value that this property has been set to.



This property raises the
[](#E-MFR-GUI-Models-OperationTypeInfo-OperationTypeChanged 'MFR.GUI.Models.OperationTypeInfo.OperationTypeChanged') event
when its value is updated.

<a name='M-MFR-GUI-Models-OperationTypeInfo-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the specified object is equal to the current
object.

##### Returns

`true` if the specified object  is equal to the current
object; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to compare with the current object. |

<a name='M-MFR-GUI-Models-OperationTypeInfo-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as the default hash function.

##### Returns

A hash code for the current object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Models-OperationTypeInfo-OnEnabledChanged'></a>
### OnEnabledChanged() `method`

##### Summary

Raises the [](#E-MFR-GUI-Models-OperationTypeInfo-EnabledChanged 'MFR.GUI.Models.OperationTypeInfo.EnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Models-OperationTypeInfo-OnNameChanged'></a>
### OnNameChanged() `method`

##### Summary

Raises the [](#E-MFR-GUI-Models-OperationTypeInfo-NameChanged 'MFR.GUI.Models.OperationTypeInfo.NameChanged') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Models-OperationTypeInfo-OnOperationTypeChanged'></a>
### OnOperationTypeChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Models-OperationTypeInfo-OperationTypeChanged 'MFR.GUI.Models.OperationTypeInfo.OperationTypeChanged') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Models-OperationTypeInfo-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

##### Remarks

This method returns the value of the
[Name](#P-MFR-GUI-Models-OperationTypeInfo-Name 'MFR.GUI.Models.OperationTypeInfo.Name') property.

<a name='T-MFR-GUI-Models-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
