<a name='assembly'></a>
# MFR.GUI.Controls.Helpers

## Contents

- [EntryRespectingComboBoxExtensions](#T-MFR-GUI-Controls-Helpers-EntryRespectingComboBoxExtensions 'MFR.GUI.Controls.Helpers.EntryRespectingComboBoxExtensions')
  - [Clear(box)](#M-MFR-GUI-Controls-Helpers-EntryRespectingComboBoxExtensions-Clear-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.GUI.Controls.Helpers.EntryRespectingComboBoxExtensions.Clear(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
  - [IsClear(box)](#M-MFR-GUI-Controls-Helpers-EntryRespectingComboBoxExtensions-IsClear-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.GUI.Controls.Helpers.EntryRespectingComboBoxExtensions.IsClear(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
- [Resources](#T-MFR-GUI-Controls-Helpers-Properties-Resources 'MFR.GUI.Controls.Helpers.Properties.Resources')
  - [Culture](#P-MFR-GUI-Controls-Helpers-Properties-Resources-Culture 'MFR.GUI.Controls.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Controls-Helpers-Properties-Resources-ResourceManager 'MFR.GUI.Controls.Helpers.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Controls-Helpers-EntryRespectingComboBoxExtensions'></a>
## EntryRespectingComboBoxExtensions `type`

##### Namespace

MFR.GUI.Controls.Helpers

##### Summary

Helper methods that augment the functionality of a [EntryRespectingComboBox](#T-MFR-GUI-Controls-EntryRespectingComboBox 'MFR.GUI.Controls.EntryRespectingComboBox').

<a name='M-MFR-GUI-Controls-Helpers-EntryRespectingComboBoxExtensions-Clear-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### Clear(box) `method`

##### Summary

Clears all the content from the combo box referenced by the
`box` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| box | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | Reference to the
[EntryRespectingComboBox](#T-MFR-GUI-Controls-EntryRespectingComboBox 'MFR.GUI.Controls.EntryRespectingComboBox')
that is
to be cleared. |

##### Remarks

This method removes all the items from the combo box and then blanks
out the text in the edit-control portion of the combo box.

<a name='M-MFR-GUI-Controls-Helpers-EntryRespectingComboBoxExtensions-IsClear-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### IsClear(box) `method`

##### Summary

Determines whether the specified
[EntryRespectingComboBox](#T-MFR-GUI-Controls-EntryRespectingComboBox 'MFR.GUI.Controls.EntryRespectingComboBox')
has any items.

##### Returns

`true` if the specified `box` is
clear of all items and entered text; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| box | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to the
[EntryRespectingComboBox](#T-MFR-GUI-Controls-EntryRespectingComboBox 'MFR.GUI.Controls.EntryRespectingComboBox')
instance to
be checked. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `box`, is passed
a `null` value. |

<a name='T-MFR-GUI-Controls-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Controls.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Controls-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Controls-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
