<a name='assembly'></a>
# MFR.GUI.Windows.Wrappers

## Contents

- [Resources](#T-MFR-GUI-Windows-Wrappers-Properties-Resources 'MFR.GUI.Windows.Wrappers.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Wrappers-Properties-Resources-Culture 'MFR.GUI.Windows.Wrappers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Wrappers-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Wrappers.Properties.Resources.ResourceManager')
- [WindowWrapper](#T-MFR-GUI-Windows-Wrappers-WindowWrapper 'MFR.GUI.Windows.Wrappers.WindowWrapper')
  - [#ctor()](#M-MFR-GUI-Windows-Wrappers-WindowWrapper-#ctor 'MFR.GUI.Windows.Wrappers.WindowWrapper.#ctor')
  - [#ctor(handle)](#M-MFR-GUI-Windows-Wrappers-WindowWrapper-#ctor-System-IntPtr- 'MFR.GUI.Windows.Wrappers.WindowWrapper.#ctor(System.IntPtr)')
  - [_handle](#F-MFR-GUI-Windows-Wrappers-WindowWrapper-_handle 'MFR.GUI.Windows.Wrappers.WindowWrapper._handle')
  - [Handle](#P-MFR-GUI-Windows-Wrappers-WindowWrapper-Handle 'MFR.GUI.Windows.Wrappers.WindowWrapper.Handle')
  - [ForWindowHandle(handle)](#M-MFR-GUI-Windows-Wrappers-WindowWrapper-ForWindowHandle-System-IntPtr- 'MFR.GUI.Windows.Wrappers.WindowWrapper.ForWindowHandle(System.IntPtr)')

<a name='T-MFR-GUI-Windows-Wrappers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Wrappers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Wrappers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Wrappers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-GUI-Windows-Wrappers-WindowWrapper'></a>
## WindowWrapper `type`

##### Namespace

MFR.GUI.Windows.Wrappers

##### Summary

Creates IWin32Window around an IntPtr

<a name='M-MFR-GUI-Windows-Wrappers-WindowWrapper-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[WindowWrapper](#T-MFR-GUI-Windows-Wrappers-WindowWrapper 'MFR.GUI.Windows.Wrappers.WindowWrapper')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-GUI-Windows-Wrappers-WindowWrapper-#ctor-System-IntPtr-'></a>
### #ctor(handle) `constructor`

##### Summary

Constructs a new instance of
[WindowWrapper](#T-MFR-GUI-Windows-Wrappers-WindowWrapper 'MFR.GUI.Windows.Wrappers.WindowWrapper')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handle | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Reference to an instance of [IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') that
provides the window handle to be wrapped by this object. |

<a name='F-MFR-GUI-Windows-Wrappers-WindowWrapper-_handle'></a>
### _handle `constants`

##### Summary

Reference to an instance of [IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') that
stores the window handle.

<a name='P-MFR-GUI-Windows-Wrappers-WindowWrapper-Handle'></a>
### Handle `property`

##### Summary

Gets the handle to the window represented by the implementer.

##### Returns

A handle to the window represented by the implementer.

<a name='M-MFR-GUI-Windows-Wrappers-WindowWrapper-ForWindowHandle-System-IntPtr-'></a>
### ForWindowHandle(handle) `method`

##### Summary

Specifies the window handle to be wrapped by this object.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handle | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | (Required.) Reference to an instance of
[IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr')
that specifies the handle of the window
that is to be wrapped by this object. |
