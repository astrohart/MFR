<a name='assembly'></a>
# MFR.GUI.Dialogs.Text.Retrievers

## Contents

- [ButtonTextRetrieverBase\`1](#T-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase`1')
  - [#ctor(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1-#ctor-`0- 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase`1.#ctor(`0)')
  - [Text](#P-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1-Text 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase`1.Text')
  - [OnSetText(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1-OnSetText-`0- 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase`1.OnSetText(`0)')
- [DialogTextRetrieverBase\`1](#T-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase`1')
  - [#ctor(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1-#ctor-`0- 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase`1.#ctor(`0)')
  - [Text](#P-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1-Text 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase`1.Text')
  - [OnSetText(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1-OnSetText-`0- 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase`1.OnSetText(`0)')
- [ProfileCreateOperationTypeButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeButtonTextRetriever')
  - [#ctor(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever-#ctor-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeButtonTextRetriever.#ctor(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
  - [Text](#P-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever-Text 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeButtonTextRetriever.Text')
  - [OnSetText(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever-OnSetText-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeButtonTextRetriever.OnSetText(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
- [ProfileCreateOperationTypeDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeDialogTextRetriever')
  - [#ctor(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever-#ctor-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeDialogTextRetriever.#ctor(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
  - [Text](#P-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever-Text 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeDialogTextRetriever.Text')
  - [OnSetText(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever-OnSetText-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeDialogTextRetriever.OnSetText(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
- [Resources](#T-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Culture 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.Culture')
  - [Error_RequestedOperationTypeNotSupported](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Error_RequestedOperationTypeNotSupported 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.Error_RequestedOperationTypeNotSupported')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.ResourceManager')
  - [Text_Buttons_Create](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Buttons_Create 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.Text_Buttons_Create')
  - [Text_Buttons_Save](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Buttons_Save 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.Text_Buttons_Save')
  - [Text_Dialogs_AddNewProifile](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Dialogs_AddNewProifile 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.Text_Dialogs_AddNewProifile')
  - [Text_Dialogs_SaveProfileAs](#P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Dialogs_SaveProfileAs 'MFR.GUI.Dialogs.Text.Retrievers.Properties.Resources.Text_Dialogs_SaveProfileAs')

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1'></a>
## ButtonTextRetrieverBase\`1 `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers

##### Summary

Defines the methods and properties that are common to all Button Text Retriever
objects.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnumerator | Enumeration type used by child classes to decide
what text that the button should display on its titlebar. |

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1-#ctor-`0-'></a>
### #ctor(enumeratorValue) `constructor`

##### Summary

Constructs a new instance of
[ButtonTextRetrieverBase](#T-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1-Text'></a>
### Text `property`

##### Summary

Gets a string containing the text that should be displayed on the button's
title bar.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase`1-OnSetText-`0-'></a>
### OnSetText(enumeratorValue) `method`

##### Summary

Called to set the value of the
[Text](#P-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase-Text 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase.Text')
property based on the value of the enumeration provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

##### Remarks

After calling this method, then read the Text property.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1'></a>
## DialogTextRetrieverBase\`1 `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers

##### Summary

Defines the methods and properties that are common to all Dialog Text Retriever
objects.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnumerator | Enumeration type used by child classes to decide
what text that the dialog should display on its titlebar. |

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1-#ctor-`0-'></a>
### #ctor(enumeratorValue) `constructor`

##### Summary

Constructs a new instance of
[DialogTextRetrieverBase](#T-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1-Text'></a>
### Text `property`

##### Summary

Gets a string containing the text that should be displayed on the dialog's
title bar.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase`1-OnSetText-`0-'></a>
### OnSetText(enumeratorValue) `method`

##### Summary

Called to set the value of the
[Text](#P-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase-Text 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase.Text')
property based on the value of the enumeration provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

##### Remarks

After calling this method, then read the Text property.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever'></a>
## ProfileCreateOperationTypeButtonTextRetriever `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers

##### Summary

Decides on what text that the OK button in the New Profile dialog box is to
have displayed on its face,
based on the operation being performed.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever-#ctor-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### #ctor(enumeratorValue) `constructor`

##### Summary

Constructs a new instance of
[ProfileCreateOperationTypeButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.ProfileCreateOperationTypeButtonTextRetriever')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) The
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that is to be used in order to decide which text to set. |

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever-Text'></a>
### Text `property`

##### Summary

Gets a string containing the text that should be displayed on the dialog's
title bar.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeButtonTextRetriever-OnSetText-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### OnSetText(enumeratorValue) `method`

##### Summary

Called to set the value of the
[Text](#P-MFR-GUI-Dialogs-Text-Retrievers-ButtonTextRetrieverBase-Text 'MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase.Text')
property based on the value of the enumeration provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

##### Remarks

After calling this method, then read the Text property.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever'></a>
## ProfileCreateOperationTypeDialogTextRetriever `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers

##### Summary

Decides on what text a New Profile dialog box is to have in its title bar,
based on the operation being performed.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever-#ctor-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### #ctor(enumeratorValue) `constructor`

##### Summary

Constructs a new instance of
[DialogTextRetrieverBase](#T-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever-Text'></a>
### Text `property`

##### Summary

Gets a string containing the text that should be displayed on the dialog's
title bar.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-ProfileCreateOperationTypeDialogTextRetriever-OnSetText-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### OnSetText(enumeratorValue) `method`

##### Summary

Called to set the value of the
[Text](#P-MFR-GUI-Dialogs-Text-Retrievers-DialogTextRetrieverBase-Text 'MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase.Text')
property based on the value of the enumeration provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

##### Remarks

After calling this method, then read the Text property.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Error_RequestedOperationTypeNotSupported'></a>
### Error_RequestedOperationTypeNotSupported `property`

##### Summary

Looks up a localized string similar to The requested operation type is not supported.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Buttons_Create'></a>
### Text_Buttons_Create `property`

##### Summary

Looks up a localized string similar to &Create.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Buttons_Save'></a>
### Text_Buttons_Save `property`

##### Summary

Looks up a localized string similar to &Save.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Dialogs_AddNewProifile'></a>
### Text_Dialogs_AddNewProifile `property`

##### Summary

Looks up a localized string similar to Add New Profile.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Properties-Resources-Text_Dialogs_SaveProfileAs'></a>
### Text_Dialogs_SaveProfileAs `property`

##### Summary

Looks up a localized string similar to Save Profile As.
