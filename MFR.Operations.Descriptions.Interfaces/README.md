<a name='assembly'></a>
# MFR.Operations.Descriptions.Interfaces

## Contents

- [IOperationTypeDescription](#T-MFR-Objects-Operations-Descriptions-Interfaces-IOperationTypeDescription 'MFR.Operations.Descriptions.Interfaces.IOperationTypeDescription')
  - [Text](#P-MFR-Objects-Operations-Descriptions-Interfaces-IOperationTypeDescription-Text 'MFR.Operations.Descriptions.Interfaces.IOperationTypeDescription.Text')
- [IOperationTypeStartedDescription](#T-MFR-Objects-Operations-Descriptions-Interfaces-IOperationTypeStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationTypeStartedDescription')
- [Resources](#T-MFR-Objects-Operations-Descriptions-Interfaces-Properties-Resources 'MFR.Operations.Descriptions.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Descriptions-Interfaces-Properties-Resources-Culture 'MFR.Operations.Descriptions.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Descriptions-Interfaces-Properties-Resources-ResourceManager 'MFR.Operations.Descriptions.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-Descriptions-Interfaces-IOperationTypeDescription'></a>
## IOperationTypeDescription `type`

##### Namespace

MFR.Operations.Descriptions.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an operation
description object.

<a name='P-MFR-Objects-Operations-Descriptions-Interfaces-IOperationTypeDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is currently being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='T-MFR-Objects-Operations-Descriptions-Interfaces-IOperationTypeStartedDescription'></a>
## IOperationTypeStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an Operation
Started Description object. This text is displayed as an operation is
just being commenced.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='T-MFR-Objects-Operations-Descriptions-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Descriptions.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Descriptions-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Descriptions-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
