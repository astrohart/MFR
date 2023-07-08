<a name='assembly'></a>
# MFR.GUI.Models.Extensions

## Contents

- [OperationTypeInfoHelpers](#T-MFR-GUI-Models-Extensions-OperationTypeInfoHelpers 'MFR.GUI.Models.Extensions.OperationTypeInfoHelpers')
  - [HasAnyOperations(source)](#M-MFR-GUI-Models-Extensions-OperationTypeInfoHelpers-HasAnyOperations-System-Collections-Generic-IList{MFR-GUI-Models-OperationTypeInfo}- 'MFR.GUI.Models.Extensions.OperationTypeInfoHelpers.HasAnyOperations(System.Collections.Generic.IList{MFR.GUI.Models.OperationTypeInfo})')
  - [IsOfType(operationTypeInfo,operationType)](#M-MFR-GUI-Models-Extensions-OperationTypeInfoHelpers-IsOfType-MFR-GUI-Models-OperationTypeInfo,MFR-Operations-Constants-OperationType- 'MFR.GUI.Models.Extensions.OperationTypeInfoHelpers.IsOfType(MFR.GUI.Models.OperationTypeInfo,MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-GUI-Models-Extensions-Properties-Resources 'MFR.GUI.Models.Extensions.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Extensions-Properties-Resources-Culture 'MFR.GUI.Models.Extensions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Extensions-Properties-Resources-ResourceManager 'MFR.GUI.Models.Extensions.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Extensions-OperationTypeInfoHelpers'></a>
## OperationTypeInfoHelpers `type`

##### Namespace

MFR.GUI.Models.Extensions

##### Summary

Exposes static methods that extend the
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') class.

<a name='M-MFR-GUI-Models-Extensions-OperationTypeInfoHelpers-HasAnyOperations-System-Collections-Generic-IList{MFR-GUI-Models-OperationTypeInfo}-'></a>
### HasAnyOperations(source) `method`

##### Summary

Determines if the collection coming from the specified
`source` has more than zero elements.

##### Returns

`true` if the `source` has more
than zero elements; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IList{MFR.GUI.Models.OperationTypeInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{MFR.GUI.Models.OperationTypeInfo}') | (Required.) A collection of instances of
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instances. |

<a name='M-MFR-GUI-Models-Extensions-OperationTypeInfoHelpers-IsOfType-MFR-GUI-Models-OperationTypeInfo,MFR-Operations-Constants-OperationType-'></a>
### IsOfType(operationTypeInfo,operationType) `method`

##### Summary

Determines whether the specified `operationTypeInfo`
represents state for the specified `operationType`.

##### Returns

`true` if the specified
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instance corresponds to the
specified `operationType`; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationTypeInfo | [MFR.GUI.Models.OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') | (Required.) An
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') that specifies the, e.g.,
enabled/disabled state for the specified operation. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration values that
explains what type of operation this object represents. |

##### Remarks

This method also returns `false` in the event that the
`operationTypeInfo` is passed `null` for its
argument.

<a name='T-MFR-GUI-Models-Extensions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Extensions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Extensions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Extensions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
