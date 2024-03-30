<a name='assembly'></a>
# MFR.Settings.Profiles.Requests

## Contents

- [CreateNewBlankProfileRequest](#T-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest')
  - [#ctor()](#M-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-#ctor 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest.#ctor')
  - [Instance](#P-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-Instance 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest.Instance')
  - [MessageType](#P-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-MessageType 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest.MessageType')
  - [#cctor()](#M-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-#cctor 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest.#cctor')
  - [CommonExecute()](#M-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-CommonExecute 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest.CommonExecute')
- [Resources](#T-MFR-Settings-Profiles-Requests-Properties-Resources 'MFR.Settings.Profiles.Requests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Requests-Properties-Resources-Culture 'MFR.Settings.Profiles.Requests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Requests-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Requests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest'></a>
## CreateNewBlankProfileRequest `type`

##### Namespace

MFR.Settings.Profiles.Requests

##### Summary

Carries out requests to create new, blank `Profile` objects.



The objects thus created have no name associated with them.



To create a new, blank profile and associate a name at the same time, call the
[CreateNewNamedProfileAction](#T-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction')
class.

<a name='M-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[CreateNewBlankProfileRequest](#T-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest').

<a name='P-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-MessageType'></a>
### MessageType `property`

##### Summary

Gets the
[MessageType](#T-MFR-MessageType 'MFR.MessageType')
that is
being used to identify which message this.

<a name='M-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface
representing the new, blank profile that has been created.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-Settings-Profiles-Requests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Requests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Requests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Requests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
