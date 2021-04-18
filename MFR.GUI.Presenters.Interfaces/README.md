<a name='assembly'></a>
# MFR.GUI.Presenters.Interfaces

## Contents

- [IPresenter\`2](#T-MFR-GUI-Presenters-Interfaces-IPresenter`2 'MFR.GUI.Presenters.Interfaces.IPresenter`2')
  - [CloseProgressDialog()](#M-MFR-GUI-Presenters-Interfaces-IPresenter`2-CloseProgressDialog 'MFR.GUI.Presenters.Interfaces.IPresenter`2.CloseProgressDialog')
  - [HavingWindowReference(mainWindow)](#M-MFR-GUI-Presenters-Interfaces-IPresenter`2-HavingWindowReference-`0- 'MFR.GUI.Presenters.Interfaces.IPresenter`2.HavingWindowReference(`0)')
  - [ShowProgressDialog()](#M-MFR-GUI-Presenters-Interfaces-IPresenter`2-ShowProgressDialog 'MFR.GUI.Presenters.Interfaces.IPresenter`2.ShowProgressDialog')
  - [UpdateData(bSavingAndValidating)](#M-MFR-GUI-Presenters-Interfaces-IPresenter`2-UpdateData-System-Boolean- 'MFR.GUI.Presenters.Interfaces.IPresenter`2.UpdateData(System.Boolean)')
- [Resources](#T-MFR-GUI-Presenters-Interfaces-Properties-Resources 'MFR.GUI.Presenters.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Presenters-Interfaces-Properties-Resources-Culture 'MFR.GUI.Presenters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Presenters-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Presenters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Presenters-Interfaces-IPresenter`2'></a>
## IPresenter\`2 `type`

##### Namespace

MFR.GUI.Presenters.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of any object that
has functionality common to all presenters.

<a name='M-MFR-GUI-Presenters-Interfaces-IPresenter`2-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Dismisses the progress dialog.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Presenters-Interfaces-IPresenter`2-HavingWindowReference-`0-'></a>
### HavingWindowReference(mainWindow) `method`

##### Summary

Fluent-builder method to set a reference to the main window of the application.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mainWindow | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of an object that is of the
`TView` type and which represents the form that
is to be associated with this presenter. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `mainWindow`, is
passed a `null` value. |

<a name='M-MFR-GUI-Presenters-Interfaces-IPresenter`2-ShowProgressDialog'></a>
### ShowProgressDialog() `method`

##### Summary

Shows the progress window.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Presenters-Interfaces-IPresenter`2-UpdateData-System-Boolean-'></a>
### UpdateData(bSavingAndValidating) `method`

##### Summary

Updates data. Moves data from the screen to the model (
`bSavingAndValidating`
equals `true`) or from
the model to the screen ( `bSavingAndValidating`
equals `false`).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bSavingAndValidating | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to `true` to move data from the screen to the
model; `false` to move data from the model to the screen. |

##### Remarks

Note that whatever operations this method performs may potentially
throw exceptions.

<a name='T-MFR-GUI-Presenters-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Presenters.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Presenters-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Presenters-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
