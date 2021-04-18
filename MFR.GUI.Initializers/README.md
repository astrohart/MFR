<a name='assembly'></a>
# MFR.GUI.Initializers

## Contents

- [ComboBoxInitializer](#T-MFR-GUI-Initializers-ComboBoxInitializer 'MFR.GUI.Initializers.ComboBoxInitializer')
  - [InitializeComboBox(comboBox,currentItem,itemList)](#M-MFR-GUI-Initializers-ComboBoxInitializer-InitializeComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IReadOnlyCollection{System-String},System-String- 'MFR.GUI.Initializers.ComboBoxInitializer.InitializeComboBox(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox,System.Collections.Generic.IReadOnlyCollection{System.String},System.String)')
- [Resources](#T-MFR-GUI-Initializers-Properties-Resources 'MFR.GUI.Initializers.Properties.Resources')
  - [Culture](#P-MFR-GUI-Initializers-Properties-Resources-Culture 'MFR.GUI.Initializers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Initializers-Properties-Resources-ResourceManager 'MFR.GUI.Initializers.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Initializers-ComboBoxInitializer'></a>
## ComboBoxInitializer `type`

##### Namespace

MFR.GUI.Initializers

##### Summary

Declares methods that assist in initializing combo boxes.

<a name='M-MFR-GUI-Initializers-ComboBoxInitializer-InitializeComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IReadOnlyCollection{System-String},System-String-'></a>
### InitializeComboBox(comboBox,currentItem,itemList) `method`

##### Summary

Initializes a [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') to have
the specified `itemList` as the items in its
drop-down, and `currentItem` as the
currently-selected item.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox')
to be initialized. |
| currentItem | [System.Collections.Generic.IReadOnlyCollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{System.String}') | (Optional.) String containing the value to set as the
currently-selected item in the combo box. |
| itemList | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Collection of one or more items that should be in the
history list of items in the combo box's body. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameters, `comboBox` and
`itemList`, are passed `null`
reference for values. |

##### Remarks

This method is intended to be utilized in order to fill combo box
controls with data from a data source.

<a name='T-MFR-GUI-Initializers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Initializers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Initializers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Initializers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
