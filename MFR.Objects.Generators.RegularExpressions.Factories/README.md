<a name='assembly'></a>
# MFR.Objects.Generators.RegularExpressions.Factories

## Contents

- [GetRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator 'MFR.Objects.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator')
  - [For(type)](#M-MFR-Objects-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator-For-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType- 'MFR.Objects.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For(MFR.Objects.Generators.RegularExpressions.Constants.RegularExpressionType)')
- [Resources](#T-MFR-Objects-Generators-RegularExpressions-Factories-Properties-Resources 'MFR.Objects.Generators.RegularExpressions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Generators-RegularExpressions-Factories-Properties-Resources-Culture 'MFR.Objects.Generators.RegularExpressions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Generators-RegularExpressions-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Generators.RegularExpressions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator'></a>
## GetRegularExpressionGenerator `type`

##### Namespace

MFR.Objects.Generators.RegularExpressions.Factories

##### Summary

Creates instances of objects that implement the
[IRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Objects.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface.

<a name='M-MFR-Objects-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator-For-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Objects.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Generators.RegularExpressions.Constants.RegularExpressionType](#T-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType 'MFR.Objects.Generators.RegularExpressions.Constants.RegularExpressionType') | (Required.) One of the
[RegularExpressionType](#T-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType 'MFR.Objects.Generators.RegularExpressions.Constants.RegularExpressionType')
values that specifies the type of regular expression that you want
to generate. |

<a name='T-MFR-Objects-Generators-RegularExpressions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Generators.RegularExpressions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Generators-RegularExpressions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Generators-RegularExpressions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
