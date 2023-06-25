<a name='assembly'></a>
# MFR.TextValues.Retrievers.Synchronization

## Contents

- [Resources](#T-MFR-TextValues-Retrievers-Synchronization-Properties-Resources 'MFR.TextValues.Retrievers.Synchronization.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Synchronization-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Synchronization.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Synchronization-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Synchronization.Properties.Resources.ResourceManager')
- [SemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker')
  - [#ctor()](#M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-#ctor 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.#ctor')
  - [Instance](#P-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-Instance 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.Instance')
  - [Semaphore](#P-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-Semaphore 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.Semaphore')
  - [#cctor()](#M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-#cctor 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.#cctor')
  - [Finalize()](#M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-Finalize 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.Finalize')
  - [LockAsync(worker)](#M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-LockAsync-System-Func{System-Threading-Tasks-Task}- 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.LockAsync(System.Func{System.Threading.Tasks.Task})')
  - [LockAsync\`\`1(worker)](#M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-LockAsync``1-System-Func{System-Threading-Tasks-Task{``0}}- 'MFR.TextValues.Retrievers.Synchronization.SemaphoreLocker.LockAsync``1(System.Func{System.Threading.Tasks.Task{``0}})')

<a name='T-MFR-TextValues-Retrievers-Synchronization-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Synchronization.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-TextValues-Retrievers-Synchronization-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-TextValues-Retrievers-Synchronization-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker'></a>
## SemaphoreLocker `type`

##### Namespace

MFR.TextValues.Retrievers.Synchronization

##### Summary

Allows the caller to put a mutex or critical section around calls to
asynchronous methods.

<a name='M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ISemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker')
interface.

<a name='P-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-Semaphore'></a>
### Semaphore `property`

##### Summary

Gets a to an instance of [SemaphoreSlim](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.SemaphoreSlim 'System.Threading.SemaphoreSlim')
that provides a semaphore to be used for asynchronous thread synchronization.

<a name='M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-Finalize'></a>
### Finalize() `method`

##### Summary

Releases the system resources associated with this object.

##### Parameters

This method has no parameters.

<a name='M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-LockAsync-System-Func{System-Threading-Tasks-Task}-'></a>
### LockAsync(worker) `method`

##### Summary

Uses a semaphore instead of a critical section to ensure that only one thread
at a time runs an asynchronous operation.

##### Returns

An awaitable [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| worker | [System.Func{System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Threading.Tasks.Task}') | (Required.) Thread that must be synchronized. |

<a name='M-MFR-TextValues-Retrievers-Synchronization-SemaphoreLocker-LockAsync``1-System-Func{System-Threading-Tasks-Task{``0}}-'></a>
### LockAsync\`\`1(worker) `method`

##### Summary

Uses a semaphore instead of a critical section to ensure that only one thread
at a time runs an asynchronous operation.

##### Returns

An awaitable [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| worker | [System.Func{System.Threading.Tasks.Task{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Threading.Tasks.Task{``0}}') | (Required.) Thread that must be synchronized. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of the return value of the specified
`worker` thread. |
