<a name='assembly'></a>
# MFR.Params.Profiles.Validators

## Contents

- [ProfileParamsValidator](#T-MFR-Params-Profiles-Validators-ProfileParamsValidator 'MFR.Params.Profiles.Validators.ProfileParamsValidator')
  - [#ctor(objectToValidate)](#M-MFR-Params-Profiles-Validators-ProfileParamsValidator-#ctor-MFR-Params-Profiles-Interfaces-IProfileParams- 'MFR.Params.Profiles.Validators.ProfileParamsValidator.#ctor(MFR.Params.Profiles.Interfaces.IProfileParams)')
  - [ProfileProvider](#P-MFR-Params-Profiles-Validators-ProfileParamsValidator-ProfileProvider 'MFR.Params.Profiles.Validators.ProfileParamsValidator.ProfileProvider')
  - [Validate()](#M-MFR-Params-Profiles-Validators-ProfileParamsValidator-Validate 'MFR.Params.Profiles.Validators.ProfileParamsValidator.Validate')
- [Resources](#T-MFR-Params-Profiles-Validators-Properties-Resources 'MFR.Params.Profiles.Validators.Properties.Resources')
  - [Culture](#P-MFR-Params-Profiles-Validators-Properties-Resources-Culture 'MFR.Params.Profiles.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Params-Profiles-Validators-Properties-Resources-ResourceManager 'MFR.Params.Profiles.Validators.Properties.Resources.ResourceManager')

<a name='T-MFR-Params-Profiles-Validators-ProfileParamsValidator'></a>
## ProfileParamsValidator `type`

##### Namespace

MFR.Params.Profiles.Validators

##### Summary

Validates the data in the properties of an instance of an object that
implements the [IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams')
interface.

<a name='M-MFR-Params-Profiles-Validators-ProfileParamsValidator-#ctor-MFR-Params-Profiles-Interfaces-IProfileParams-'></a>
### #ctor(objectToValidate) `constructor`

##### Summary

Constructs a new instance of
[ObjectValidatorBase](#T-xyLOGIX-Validators-ObjectValidatorBase 'xyLOGIX.Validators.ObjectValidatorBase')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectToValidate | [MFR.Params.Profiles.Interfaces.IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') | (Required.) Reference to an instance of an object that implements the
[IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') interface that
has the data to be validated. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `objectToValidate`, is passed a
`null` value. |

<a name='P-MFR-Params-Profiles-Validators-ProfileParamsValidator-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='M-MFR-Params-Profiles-Validators-ProfileParamsValidator-Validate'></a>
### Validate() `method`

##### Summary

When implemented by a class, evaluates the condition it checks and
updates the [IsValid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Web.UI.IValidator.IsValid 'System.Web.UI.IValidator.IsValid') property.

##### Parameters

This method has no parameters.

<a name='T-MFR-Params-Profiles-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Params.Profiles.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Params-Profiles-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Params-Profiles-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
