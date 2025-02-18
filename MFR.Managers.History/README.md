<a name='assembly'></a>
# MFR.Managers.History

## Contents

- [HistoryManager](#T-MFR-Managers-History-HistoryManager 'MFR.Managers.History.HistoryManager')
  - [#ctor(messageBoxParentWindow)](#M-MFR-Managers-History-HistoryManager-#ctor-System-Windows-Forms-IWin32Window- 'MFR.Managers.History.HistoryManager.#ctor(System.Windows.Forms.IWin32Window)')
  - [_messageBoxParentWindow](#F-MFR-Managers-History-HistoryManager-_messageBoxParentWindow 'MFR.Managers.History.HistoryManager._messageBoxParentWindow')
  - [ConfigProvider](#P-MFR-Managers-History-HistoryManager-ConfigProvider 'MFR.Managers.History.HistoryManager.ConfigProvider')
  - [CurrentConfig](#P-MFR-Managers-History-HistoryManager-CurrentConfig 'MFR.Managers.History.HistoryManager.CurrentConfig')
  - [#cctor()](#M-MFR-Managers-History-HistoryManager-#cctor 'MFR.Managers.History.HistoryManager.#cctor')
  - [CanClearAll()](#M-MFR-Managers-History-HistoryManager-CanClearAll 'MFR.Managers.History.HistoryManager.CanClearAll')
  - [ClearAll()](#M-MFR-Managers-History-HistoryManager-ClearAll 'MFR.Managers.History.HistoryManager.ClearAll')
- [Resources](#T-MFR-Managers-History-Properties-Resources 'MFR.Managers.History.Properties.Resources')
  - [Culture](#P-MFR-Managers-History-Properties-Resources-Culture 'MFR.Managers.History.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-History-Properties-Resources-ResourceManager 'MFR.Managers.History.Properties.Resources.ResourceManager')

<a name='T-MFR-Managers-History-HistoryManager'></a>
## HistoryManager `type`

##### Namespace

MFR.Managers.History

##### Summary

Manages the config history on behalf of the application.

<a name='M-MFR-Managers-History-HistoryManager-#ctor-System-Windows-Forms-IWin32Window-'></a>
### #ctor(messageBoxParentWindow) `constructor`

##### Summary

Constructs a new instance of
[HistoryManager](#T-MFR-HistoryManager 'MFR.HistoryManager')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageBoxParentWindow | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface and
which will serve as the parent window for any message boxes
displayed by this object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`messageBoxParentWindow`
, is passed a `null` value. |

<a name='F-MFR-Managers-History-HistoryManager-_messageBoxParentWindow'></a>
### _messageBoxParentWindow `constants`

##### Summary

Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window')
interface.

##### Remarks

This field is supposed to be filled with a reference to an object
that represents the main window of the application.

<a name='P-MFR-Managers-History-HistoryManager-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Managers-History-HistoryManager-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='M-MFR-Managers-History-HistoryManager-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [HistoryManager](#T-MFR-Managers-History-HistoryManager 'MFR.Managers.History.HistoryManager') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Managers-History-HistoryManager-CanClearAll'></a>
### CanClearAll() `method`

##### Summary

Gets a value indicating whether we can clear all the history objects
or not.

##### Returns

`true` if the user confirms that all the history can
be cleared; `false` otherwise.

##### Parameters

This method has no parameters.

##### Remarks

This method does nothing but return `false` if all
the history lists are already clear, since, in that event, this
means that there is nothing to do.

<a name='M-MFR-Managers-History-HistoryManager-ClearAll'></a>
### ClearAll() `method`

##### Summary

Clears all the history objects in a config object.

##### Returns

`true` if the Clear operation was carried out
successfully; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='T-MFR-Managers-History-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.History.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-History-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-History-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
