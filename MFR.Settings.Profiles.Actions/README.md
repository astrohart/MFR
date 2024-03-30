<a name='assembly'></a>
# MFR.Settings.Profiles.Actions

## Contents

- [CreateNewNamedProfileAction](#T-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction')
  - [#ctor()](#M-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-#ctor 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction.#ctor')
  - [Instance](#P-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-Instance 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction.Instance')
  - [MessageType](#P-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-MessageType 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction.MessageType')
  - [#cctor()](#M-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-#cctor 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction.#cctor')
  - [CommonExecute()](#M-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-CommonExecute 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction.CommonExecute')
- [LoadProfileCollectionFilePathFromRegistryAction](#T-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction')
  - [#ctor()](#M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-#ctor 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction.#ctor')
  - [AccessRegQueryExpressionValidator](#P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-AccessRegQueryExpressionValidator 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction.AccessRegQueryExpressionValidator')
  - [Instance](#P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-Instance 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction.Instance')
  - [MessageType](#P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-MessageType 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction.MessageType')
  - [#cctor()](#M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-#cctor 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction.#cctor')
  - [ExecuteOperationIfNotCached()](#M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-ExecuteOperationIfNotCached 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction.ExecuteOperationIfNotCached')
- [LoadProfileCollectionFromFileAction](#T-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction')
  - [#ctor()](#M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-#ctor 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction.#ctor')
  - [Instance](#P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-Instance 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction.Instance')
  - [MessageType](#P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-MessageType 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction.MessageType')
  - [#cctor()](#M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-#cctor 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction.#cctor')
  - [CommonExecute()](#M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-CommonExecute 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction.CommonExecute')
- [Resources](#T-MFR-Settings-Profiles-Actions-Properties-Resources 'MFR.Settings.Profiles.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Actions-Properties-Resources-Culture 'MFR.Settings.Profiles.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction'></a>
## CreateNewNamedProfileAction `type`

##### Namespace

MFR.Settings.Profiles.Actions

##### Summary

Creates a new, blank `Profile` object and assigns the name specified in
this `Action`'s input to it.



To create a new profile with no name assigned, use the
[CreateNewBlankProfileRequest](#T-MFR-Settings-Profiles-Requests-CreateNewBlankProfileRequest 'MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest')
class.

<a name='M-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[CreateNewNamedProfileAction](#T-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction 'MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction').

<a name='P-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the
[MessageType](#T-MFR-MessageType 'MFR.MessageType')
that is
being used to identify which message this.

<a name='M-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Actions-CreateNewNamedProfileAction-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface and which
represents a `Profile` object having the name passed as input to this
`Action`.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction'></a>
## LoadProfileCollectionFilePathFromRegistryAction `type`

##### Namespace

MFR.Settings.Profiles.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master config file.

<a name='M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-AccessRegQueryExpressionValidator'></a>
### AccessRegQueryExpressionValidator `property`

##### Summary

Accesses a Registry query expression validator object that decides whether
Registry query expression objects for `REG_SZ` values are initialized
properly.

<a name='P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadProfileCollectionFilePathFromRegistryAction](#T-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction')
.

<a name='P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is being used
to identify which message this.

<a name='M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFilePathFromRegistryAction-ExecuteOperationIfNotCached'></a>
### ExecuteOperationIfNotCached() `method`

##### Summary

Performs this action's operation if the result could not located in
the result cache.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that corresponds to the result of executing the action.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.



This a template method, the call to which is wrapped in a robust
and fault-tolerant override of the
[CommonExecute](#M-MFR-ActionBase-CommonExecute 'MFR.ActionBase.CommonExecute')
method.



The parent method override (a) validates that the _input field is
not null, (b) checks for thrown exceptions, and(c) checks the result
cache first to see if data corresponding to the input is there.

<a name='T-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction'></a>
## LoadProfileCollectionFromFileAction `type`

##### Namespace

MFR.Settings.Profiles.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master config file.

<a name='M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadProfileCollectionFromFileAction](#T-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction 'MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction')
.

<a name='P-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is being used
to identify which message this.

<a name='M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Actions-LoadProfileCollectionFromFileAction-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

Reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface that is initialized with the values read in from the
specified file.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-Settings-Profiles-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
