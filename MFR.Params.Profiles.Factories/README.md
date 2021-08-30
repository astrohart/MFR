<a name='assembly'></a>
# MFR.Params.Profiles.Factories

## Contents

- [MakeNewProfileParams](#T-MFR-Params-Profiles-Factories-MakeNewProfileParams 'MFR.Params.Profiles.Factories.MakeNewProfileParams')
  - [FromScratch()](#M-MFR-Params-Profiles-Factories-MakeNewProfileParams-FromScratch 'MFR.Params.Profiles.Factories.MakeNewProfileParams.FromScratch')
  - [HavingName(self,name)](#M-MFR-Params-Profiles-Factories-MakeNewProfileParams-HavingName-MFR-Params-Profiles-Interfaces-IProfileParams,System-String- 'MFR.Params.Profiles.Factories.MakeNewProfileParams.HavingName(MFR.Params.Profiles.Interfaces.IProfileParams,System.String)')
- [Resources](#T-MFR-Params-Profiles-Factories-Properties-Resources 'MFR.Params.Profiles.Factories.Properties.Resources')
  - [Culture](#P-MFR-Params-Profiles-Factories-Properties-Resources-Culture 'MFR.Params.Profiles.Factories.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhitespace](#P-MFR-Params-Profiles-Factories-Properties-Resources-Error_ValueCannotBeNullOrWhitespace 'MFR.Params.Profiles.Factories.Properties.Resources.Error_ValueCannotBeNullOrWhitespace')
  - [ResourceManager](#P-MFR-Params-Profiles-Factories-Properties-Resources-ResourceManager 'MFR.Params.Profiles.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Params-Profiles-Factories-MakeNewProfileParams'></a>
## MakeNewProfileParams `type`

##### Namespace

MFR.Params.Profiles.Factories

##### Summary

Creates new instances of objects that implement the
[IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') interface, and
returns references to them.

<a name='M-MFR-Params-Profiles-Factories-MakeNewProfileParams-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Params-Profiles-Factories-MakeNewProfileParams-HavingName-MFR-Params-Profiles-Interfaces-IProfileParams,System-String-'></a>
### HavingName(self,name) `method`

##### Summary

Assigns the specified `name` to the profile params object.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Params.Profiles.Interfaces.IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams') | (Required.) Reference to an instance of an object that
implements the [IProfileParams](#T-MFR-Params-Profiles-Interfaces-IProfileParams 'MFR.Params.Profiles.Interfaces.IProfileParams')
interface to which the new `name` should be assigned. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new name to assign to the profile params
object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `self`, is passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`name`, is passed a blank or `null` string
for a value. |

<a name='T-MFR-Params-Profiles-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Params.Profiles.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Params-Profiles-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Params-Profiles-Factories-Properties-Resources-Error_ValueCannotBeNullOrWhitespace'></a>
### Error_ValueCannotBeNullOrWhitespace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Params-Profiles-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
