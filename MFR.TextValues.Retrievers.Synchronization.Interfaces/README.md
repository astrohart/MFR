<a name='assembly'></a>
# MFR.TextValues.Retrievers.Synchronization.Interfaces

## Contents

- [ISemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker')
  - [LockAsync(worker)](#M-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker-LockAsync-System-Func{System-Threading-Tasks-Task}- 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker.LockAsync(System.Func{System.Threading.Tasks.Task})')
  - [LockAsync\`\`1(worker)](#M-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker-LockAsync``1-System-Func{System-Threading-Tasks-Task{``0}}- 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker.LockAsync``1(System.Func{System.Threading.Tasks.Task{``0}})')
- [Resources](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-Properties-Resources 'MFR.TextValues.Retrievers.Synchronization.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Synchronization-Interfaces-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Synchronization.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Synchronization-Interfaces-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Synchronization.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker'></a>
## ISemaphoreLocker `type`

##### Namespace

MFR.TextValues.Retrievers.Synchronization.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that manages
semaphore locks for asynchronous method calls..

<a name='M-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker-LockAsync-System-Func{System-Threading-Tasks-Task}-'></a>
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

<a name='M-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker-LockAsync``1-System-Func{System-Threading-Tasks-Task{``0}}-'></a>
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

<a name='T-MFR-TextValues-Retrievers-Synchronization-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Synchronization.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-TextValues-Retrievers-Synchronization-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-TextValues-Retrievers-Synchronization-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
