<a name='assembly'></a>
# MFR.GUI.Models.Events

## Contents

- [OperationTypeChangedEventArgs](#T-MFR-GUI-Models-Events-OperationTypeChangedEventArgs 'MFR.GUI.Models.Events.OperationTypeChangedEventArgs')
  - [#ctor(oldValue,newValue)](#M-MFR-GUI-Models-Events-OperationTypeChangedEventArgs-#ctor-MFR-Operations-Constants-OperationType,MFR-Operations-Constants-OperationType- 'MFR.GUI.Models.Events.OperationTypeChangedEventArgs.#ctor(MFR.Operations.Constants.OperationType,MFR.Operations.Constants.OperationType)')
  - [NewValue](#P-MFR-GUI-Models-Events-OperationTypeChangedEventArgs-NewValue 'MFR.GUI.Models.Events.OperationTypeChangedEventArgs.NewValue')
  - [OldValue](#P-MFR-GUI-Models-Events-OperationTypeChangedEventArgs-OldValue 'MFR.GUI.Models.Events.OperationTypeChangedEventArgs.OldValue')
- [OperationTypeChangedEventHandler](#T-MFR-GUI-Models-Events-OperationTypeChangedEventHandler 'MFR.GUI.Models.Events.OperationTypeChangedEventHandler')
- [Resources](#T-MFR-GUI-Models-Events-Properties-Resources 'MFR.GUI.Models.Events.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Events-Properties-Resources-Culture 'MFR.GUI.Models.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Events-Properties-Resources-ResourceManager 'MFR.GUI.Models.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Events-OperationTypeChangedEventArgs'></a>
## OperationTypeChangedEventArgs `type`

##### Namespace

MFR.GUI.Models.Events

##### Summary

Provides information for `OperationTypeChanged` event handlers.

<a name='M-MFR-GUI-Models-Events-OperationTypeChangedEventArgs-#ctor-MFR-Operations-Constants-OperationType,MFR-Operations-Constants-OperationType-'></a>
### #ctor(oldValue,newValue) `constructor`

##### Summary

Constructs a new instance of
[OperationTypeChangedEventArgs](#T-MFR-GUI-Models-Events-OperationTypeChangedEventArgs 'MFR.GUI.Models.Events.OperationTypeChangedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oldValue | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that represents the former value. |
| newValue | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that represents the current value. |

<a name='P-MFR-GUI-Models-Events-OperationTypeChangedEventArgs-NewValue'></a>
### NewValue `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration values that indicates the current operation type.

<a name='P-MFR-GUI-Models-Events-OperationTypeChangedEventArgs-OldValue'></a>
### OldValue `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration values that indicates the former value of the assigned
`OperationType`.

<a name='T-MFR-GUI-Models-Events-OperationTypeChangedEventHandler'></a>
## OperationTypeChangedEventHandler `type`

##### Namespace

MFR.GUI.Models.Events

##### Summary

Represents a handler for a `OperationTypeChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Models.Events.OperationTypeChangedEventHandler](#T-T-MFR-GUI-Models-Events-OperationTypeChangedEventHandler 'T:MFR.GUI.Models.Events.OperationTypeChangedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`OperationTypeChanged` event.

<a name='T-MFR-GUI-Models-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
