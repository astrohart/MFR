<a name='assembly'></a>
# MFR.GUI.Dialogs.Text.Retrievers.Factories

## Contents

- [ButtonTextRetrieverFactoryBase\`1](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-ButtonTextRetrieverFactoryBase`1 'MFR.GUI.Dialogs.Text.Retrievers.Factories.ButtonTextRetrieverFactoryBase`1')
  - [EnumerationValue(retrieverType)](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-ButtonTextRetrieverFactoryBase`1-EnumerationValue-`0- 'MFR.GUI.Dialogs.Text.Retrievers.Factories.ButtonTextRetrieverFactoryBase`1.EnumerationValue(`0)')
- [DialogTextRetrieverFactoryBase\`1](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-DialogTextRetrieverFactoryBase`1 'MFR.GUI.Dialogs.Text.Retrievers.Factories.DialogTextRetrieverFactoryBase`1')
  - [EnumerationValue(retrieverType)](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-DialogTextRetrieverFactoryBase`1-EnumerationValue-`0- 'MFR.GUI.Dialogs.Text.Retrievers.Factories.DialogTextRetrieverFactoryBase`1.EnumerationValue(`0)')
- [GetProfileCreateOperationTypeButtonText](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeButtonText')
  - [#ctor()](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-#ctor 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeButtonText.#ctor')
  - [By](#P-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-By 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeButtonText.By')
  - [#cctor()](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-#cctor 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeButtonText.#cctor')
  - [EnumerationValue(retrieverType)](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-EnumerationValue-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeButtonText.EnumerationValue(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
- [GetProfileCreateOperationTypeDialogText](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText')
  - [#ctor()](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-#ctor 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText.#ctor')
  - [By](#P-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-By 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText.By')
  - [#cctor()](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-#cctor 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText.#cctor')
  - [EnumerationValue(retrieverType)](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-EnumerationValue-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText.EnumerationValue(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
- [MakeNewProfileCreateOperationTypeButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Factories.MakeNewProfileCreateOperationTypeButtonTextRetriever')
  - [FromScratch(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeButtonTextRetriever-FromScratch-System-Object- 'MFR.GUI.Dialogs.Text.Retrievers.Factories.MakeNewProfileCreateOperationTypeButtonTextRetriever.FromScratch(System.Object)')
- [MakeNewProfileCreateOperationTypeDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Factories.MakeNewProfileCreateOperationTypeDialogTextRetriever')
  - [FromScratch(enumeratorValue)](#M-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeDialogTextRetriever-FromScratch-System-Object- 'MFR.GUI.Dialogs.Text.Retrievers.Factories.MakeNewProfileCreateOperationTypeDialogTextRetriever.FromScratch(System.Object)')
- [Resources](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-Properties-Resources 'MFR.GUI.Dialogs.Text.Retrievers.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Text-Retrievers-Factories-Properties-Resources-Culture 'MFR.GUI.Dialogs.Text.Retrievers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Text-Retrievers-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Text.Retrievers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-ButtonTextRetrieverFactoryBase`1'></a>
## ButtonTextRetrieverFactoryBase\`1 `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[IButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever')
interface.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnumerator | Type name of the enumeration that is used to
decide which object to create. |

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-ButtonTextRetrieverFactoryBase`1-EnumerationValue-`0-'></a>
### EnumerationValue(retrieverType) `method`

##### Summary

Creates a new instance of an object that implements the
[IButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever')
interface and returns a reference to it.

##### Returns

String containing the text that should be displayed on the calling dialog box's
title bar.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| retrieverType | [\`0](#T-`0 '`0') | (Required.) One of the `TEnumerator` values that
specifies which dialog text retriever object to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object retrieverType requested is not supported. |

##### Remarks

This method is to be used for dialog boxes whose title bar text varies
slightly, depending on the specific user operation for which the dialog box was
summoned.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-DialogTextRetrieverFactoryBase`1'></a>
## DialogTextRetrieverFactoryBase\`1 `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[IDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever')
interface.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnumerator | Type name of the enumeration that is used to
decide which object to create. |

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-DialogTextRetrieverFactoryBase`1-EnumerationValue-`0-'></a>
### EnumerationValue(retrieverType) `method`

##### Summary

Creates a new instance of an object that implements the
[IDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever')
interface and returns a reference to it.

##### Returns

String containing the text that should be displayed on the calling dialog box's
title bar.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| retrieverType | [\`0](#T-`0 '`0') | (Required.) One of the `TEnumerator` values that
specifies which dialog text retriever object to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object retrieverType requested is not supported. |

##### Remarks

This method is to be used for dialog boxes whose title bar text varies
slightly, depending on the specific user operation for which the dialog box was
summoned.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText'></a>
## GetProfileCreateOperationTypeButtonText `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories

##### Summary

Retrieves the text to be displayed on a button's face given a
particular
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-By'></a>
### By `property`

##### Summary

Gets a reference to the one and only instance of
[GetProfileCreateOperationTypeButtonText](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeButtonText')
.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeButtonText-EnumerationValue-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### EnumerationValue(retrieverType) `method`

##### Summary

Creates a new instance of an object that implements the
[IButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever')
interface and returns a reference to it.

##### Returns

String containing the text that should be displayed on a button's face.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| retrieverType | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) One of the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') values
that
specifies which button text retriever object to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object retrieverType requested is not supported. |

##### Remarks

This method is to be used for buttons whose text varies slightly, depending on
the specific user operation for which the dialog box was summoned.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText'></a>
## GetProfileCreateOperationTypeDialogText `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories

##### Summary

Retrieves the text to be displayed on a dialog box's title bar given a
particular
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-By'></a>
### By `property`

##### Summary

Gets a reference to the one and only instance of
[GetProfileCreateOperationTypeDialogText](#T-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText 'MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText')
.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-GetProfileCreateOperationTypeDialogText-EnumerationValue-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### EnumerationValue(retrieverType) `method`

##### Summary

Creates a new instance of an object that implements the
[IDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever')
interface and returns a reference to it.

##### Returns

String containing the text that should be displayed on the calling dialog box's
title bar.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| retrieverType | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) One of the [ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') values that
specifies which dialog text retriever object to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object retrieverType requested is not supported. |

##### Remarks

This method is to be used for dialog boxes whose title bar text varies
slightly, depending on the specific user operation for which the dialog box was
summoned.

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeButtonTextRetriever'></a>
## MakeNewProfileCreateOperationTypeButtonTextRetriever `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories

##### Summary

Creates new instances of objects that implement the
[IButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever')
interface, specifically for the values of the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType')
enumeration, and returns references to them.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeButtonTextRetriever-FromScratch-System-Object-'></a>
### FromScratch(enumeratorValue) `method`

##### Summary

Creates a new instance of an object that implements the
[IButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IButtonTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IButtonTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeDialogTextRetriever'></a>
## MakeNewProfileCreateOperationTypeDialogTextRetriever `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories

##### Summary

Creates new instances of objects that implement the
[IDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever')
interface, specifically for the values of the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType')
enumeration, and returns references to them.

<a name='M-MFR-GUI-Dialogs-Text-Retrievers-Factories-MakeNewProfileCreateOperationTypeDialogTextRetriever-FromScratch-System-Object-'></a>
### FromScratch(enumeratorValue) `method`

##### Summary

Creates a new instance of an object that implements the
[IDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IDialogTextRetriever](#T-MFR-GUI-Dialogs-Text-Retrievers-Interfaces-IDialogTextRetriever 'MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumeratorValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to an instance of the enumeration used to decide which
text to set. |

<a name='T-MFR-GUI-Dialogs-Text-Retrievers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Text.Retrievers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Text-Retrievers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
