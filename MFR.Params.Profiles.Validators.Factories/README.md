<a name='assembly'></a>
# MFR.Params.Profiles.Validators.Factories

## Contents

- [MakeNewProfileParamsValidator](#T-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator 'MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator')
  - [#ctor()](#M-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-#ctor 'MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator.#ctor')
  - [For](#P-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-For 'MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator.For')
  - [#cctor()](#M-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-#cctor 'MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator.#cctor')
  - [Object(objectToValidate)](#M-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-Object-MFR-Params-Profiles-Interfaces-IProfileParams- 'MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator.Object(MFR.Params.Profiles.Interfaces.IProfileParams)')
- [Resources](#T-MFR-Params-Profiles-Validators-Factories-Properties-Resources 'MFR.Params.Profiles.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-Params-Profiles-Validators-Factories-Properties-Resources-Culture 'MFR.Params.Profiles.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Params-Profiles-Validators-Factories-Properties-Resources-ResourceManager 'MFR.Params.Profiles.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator'></a>
## MakeNewProfileParamsValidator `type`

##### Namespace

MFR.Params.Profiles.Validators.Factories

##### Summary

Creates new instances of validator objects that check the properties of
instances of objects that implement the
[IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') interface.

<a name='M-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-For'></a>
### For `property`

##### Summary

Gets a reference to the one and only instance of
[MakeNewProfileParamsValidator](#T-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator 'MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator')
.

<a name='M-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Params-Profiles-Validators-Factories-MakeNewProfileParamsValidator-Object-MFR-Params-Profiles-Interfaces-IProfileParams-'></a>
### Object(objectToValidate) `method`

##### Summary

Creates a new instance of an object that implements the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface and
returns a reference to it, for the `objectToValidate`
specified.

##### Returns

Reference to an instance of an object that implements the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectToValidate | [MFR.Params.Profiles.Interfaces.IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') | (Required.) Reference to an instance of the object whose properties' values are
to be validated. |

<a name='T-MFR-Params-Profiles-Validators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Params.Profiles.Validators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Params-Profiles-Validators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Params-Profiles-Validators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
