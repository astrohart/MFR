<a name='assembly'></a>
# MFR.Settings.Profiles.Requests.Factories

## Contents

- [GetProfileCollectionRequest](#T-MFR-Settings-Profiles-Requests-Factories-GetProfileCollectionRequest 'MFR.Settings.Profiles.Requests.Factories.GetProfileCollectionRequest')
  - [For\`\`1(requestType)](#M-MFR-Settings-Profiles-Requests-Factories-GetProfileCollectionRequest-For``1-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequest- 'MFR.Settings.Profiles.Requests.Factories.GetProfileCollectionRequest.For``1(MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequest)')
- [Resources](#T-MFR-Settings-Profiles-Requests-Factories-Properties-Resources 'MFR.Settings.Profiles.Requests.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Requests-Factories-Properties-Resources-Culture 'MFR.Settings.Profiles.Requests.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Requests-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Requests.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Requests-Factories-GetProfileCollectionRequest'></a>
## GetProfileCollectionRequest `type`

##### Namespace

MFR.Settings.Profiles.Requests.Factories

##### Summary

Creates instances of objects that implement the
[IRequest](#T-MFR-Messages-Requests-Intefaces-IRequest 'MFR.Messages.Requests.Intefaces.IRequest')
interface, in order to carry out requests on the list of profiles.

##### Remarks

In our parlance, an Request is a process that has both an input and an output.

<a name='M-MFR-Settings-Profiles-Requests-Factories-GetProfileCollectionRequest-For``1-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequest-'></a>
### For\`\`1(requestType) `method`

##### Summary

Creates a new instance of an object that implements the
[IRequest](#T-MFR-Messages-Requests-Intefaces-IRequest 'MFR.Messages.Requests.Intefaces.IRequest')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IRequest](#T-MFR-Messages-Requests-Interfaces-IRequest 'MFR.Messages.Requests.Interfaces.IRequest')
interface
that corresponds to the specified
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestType | [MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequest](#T-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequest 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequest') | (Required.) A
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value that
indicates what request to carry out. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no request is available that corresponds to the
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value provided
in the `requestType` parameter. |

<a name='T-MFR-Settings-Profiles-Requests-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Requests.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Requests-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Requests-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
