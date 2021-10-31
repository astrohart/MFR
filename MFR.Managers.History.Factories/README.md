<a name='assembly'></a>
# MFR.Managers.History.Factories

## Contents

- [MakeHistoryManager](#T-MFR-Objects-Managers-History-Factories-MakeHistoryManager 'MFR.Managers.History.Factories.MakeHistoryManager')
  - [ForForm(form)](#M-MFR-Objects-Managers-History-Factories-MakeHistoryManager-ForForm-System-Windows-Forms-IWin32Window- 'MFR.Managers.History.Factories.MakeHistoryManager.ForForm(System.Windows.Forms.IWin32Window)')
- [Resources](#T-MFR-Objects-Managers-History-Factories-Properties-Resources 'MFR.Managers.History.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Managers-History-Factories-Properties-Resources-Culture 'MFR.Managers.History.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Managers-History-Factories-Properties-Resources-ResourceManager 'MFR.Managers.History.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Managers-History-Factories-MakeHistoryManager'></a>
## MakeHistoryManager `type`

##### Namespace

MFR.Managers.History.Factories

##### Summary

Creates new instances of History Manager objects.

<a name='M-MFR-Objects-Managers-History-Factories-MakeHistoryManager-ForForm-System-Windows-Forms-IWin32Window-'></a>
### ForForm(form) `method`

##### Summary

Obtains a reference to an newly-created instance of a History
Manager object that is associated with the specified `form`.

##### Returns

Reference to an instance of an object that implements the
[IHistoryManager](#T-MFR-Objects-IHistoryManager 'MFR.IHistoryManager')
interface and
which is associated with the specified `form`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object should represent the parent form of the controls for
which the returned History Manager object is managing input history. |

<a name='T-MFR-Objects-Managers-History-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.History.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Managers-History-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Managers-History-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
