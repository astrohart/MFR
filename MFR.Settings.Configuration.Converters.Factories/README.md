<a name='assembly'></a>
# MFR.Settings.Configuration.Converters.Factories

## Contents

- [MakeNewOperationTypeInfoConverter](#T-MFR-Settings-Configuration-Converters-Factories-MakeNewOperationTypeInfoConverter 'MFR.Settings.Configuration.Converters.Factories.MakeNewOperationTypeInfoConverter')
  - [FromScratch\`\`1()](#M-MFR-Settings-Configuration-Converters-Factories-MakeNewOperationTypeInfoConverter-FromScratch``1 'MFR.Settings.Configuration.Converters.Factories.MakeNewOperationTypeInfoConverter.FromScratch``1')
- [Resources](#T-MFR-Settings-Configuration-Converters-Factories-Properties-Resources 'MFR.Settings.Configuration.Converters.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Converters-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Converters.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Converters-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Converters.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Converters-Factories-MakeNewOperationTypeInfoConverter'></a>
## MakeNewOperationTypeInfoConverter `type`

##### Namespace

MFR.Settings.Configuration.Converters.Factories

##### Summary

Creates instances of objects that implement the
[IOperationTypeInfoConverter](#T-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter')
interface and returns references to them.

<a name='M-MFR-Settings-Configuration-Converters-Factories-MakeNewOperationTypeInfoConverter-FromScratch``1'></a>
### FromScratch\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the
[IOperationTypeInfoConverter](#T-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IOperationTypeInfoConverter](#T-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter')
interface for the model class specified in the
`T` generic parameter.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Fully-qualified name of the
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') model class that should be
wrapped by the converter object. |

<a name='T-MFR-Settings-Configuration-Converters-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Converters.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Converters-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Converters-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
