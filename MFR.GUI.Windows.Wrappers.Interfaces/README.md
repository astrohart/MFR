<a name='assembly'></a>
# MFR.GUI.Windows.Wrappers.Interfaces

## Contents

- [IWindowWrapper](#T-MFR-GUI-Windows-Wrappers-Interfaces-IWindowWrapper 'MFR.GUI.Windows.Wrappers.Interfaces.IWindowWrapper')
  - [ForWindowHandle(handle)](#M-MFR-GUI-Windows-Wrappers-Interfaces-IWindowWrapper-ForWindowHandle-System-IntPtr- 'MFR.GUI.Windows.Wrappers.Interfaces.IWindowWrapper.ForWindowHandle(System.IntPtr)')
- [Resources](#T-MFR-GUI-Windows-Wrappers-Interfaces-Properties-Resources 'MFR.GUI.Windows.Wrappers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Wrappers-Interfaces-Properties-Resources-Culture 'MFR.GUI.Windows.Wrappers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Wrappers-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Wrappers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Wrappers-Interfaces-IWindowWrapper'></a>
## IWindowWrapper `type`

##### Namespace

MFR.GUI.Windows.Wrappers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a window-wrapper object.

<a name='M-MFR-GUI-Windows-Wrappers-Interfaces-IWindowWrapper-ForWindowHandle-System-IntPtr-'></a>
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

<a name='T-MFR-GUI-Windows-Wrappers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Wrappers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Wrappers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Wrappers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
