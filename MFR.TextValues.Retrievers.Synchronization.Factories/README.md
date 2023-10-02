<a name='assembly'></a>
# MFR.TextValues.Retrievers.Synchronization.Factories

## Contents

- [GetSemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Factories-GetSemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Factories.GetSemaphoreLocker')
  - [SoleInstance()](#M-MFR-TextValues-Retrievers-Synchronization-Factories-GetSemaphoreLocker-SoleInstance 'MFR.TextValues.Retrievers.Synchronization.Factories.GetSemaphoreLocker.SoleInstance')
- [Resources](#T-MFR-TextValues-Retrievers-Synchronization-Factories-Properties-Resources 'MFR.TextValues.Retrievers.Synchronization.Factories.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Synchronization-Factories-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Synchronization.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Synchronization-Factories-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Synchronization.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-TextValues-Retrievers-Synchronization-Factories-GetSemaphoreLocker'></a>
## GetSemaphoreLocker `type`

##### Namespace

MFR.TextValues.Retrievers.Synchronization.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ISemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker')
interface.

<a name='M-MFR-TextValues-Retrievers-Synchronization-Factories-GetSemaphoreLocker-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ISemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ISemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-TextValues-Retrievers-Synchronization-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Synchronization.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-TextValues-Retrievers-Synchronization-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-TextValues-Retrievers-Synchronization-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
