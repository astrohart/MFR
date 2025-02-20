<a name='assembly'></a>
# MFR.GUI.Initializers

## Contents

- [ComboBoxInitializer](#T-MFR-GUI-Initializers-ComboBoxInitializer 'MFR.GUI.Initializers.ComboBoxInitializer')
  - [#cctor()](#M-MFR-GUI-Initializers-ComboBoxInitializer-#cctor 'MFR.GUI.Initializers.ComboBoxInitializer.#cctor')
  - [AddCurrentItemToComboBox(comboBox,itemList,currentItem)](#M-MFR-GUI-Initializers-ComboBoxInitializer-AddCurrentItemToComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IList{System-String},System-String- 'MFR.GUI.Initializers.ComboBoxInitializer.AddCurrentItemToComboBox(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox,System.Collections.Generic.IList{System.String},System.String)')
  - [AddItemsToComboBox(comboBox,itemList)](#M-MFR-GUI-Initializers-ComboBoxInitializer-AddItemsToComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IList{System-String}- 'MFR.GUI.Initializers.ComboBoxInitializer.AddItemsToComboBox(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox,System.Collections.Generic.IList{System.String})')
  - [InitializeComboBox(comboBox,currentItem,itemList)](#M-MFR-GUI-Initializers-ComboBoxInitializer-InitializeComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IList{System-String},System-String- 'MFR.GUI.Initializers.ComboBoxInitializer.InitializeComboBox(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox,System.Collections.Generic.IList{System.String},System.String)')
  - [SelectAppropriateItem(comboBox,currentItem)](#M-MFR-GUI-Initializers-ComboBoxInitializer-SelectAppropriateItem-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-String- 'MFR.GUI.Initializers.ComboBoxInitializer.SelectAppropriateItem(MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox,System.String)')
- [Resources](#T-MFR-GUI-Initializers-Properties-Resources 'MFR.GUI.Initializers.Properties.Resources')
  - [Culture](#P-MFR-GUI-Initializers-Properties-Resources-Culture 'MFR.GUI.Initializers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Initializers-Properties-Resources-ResourceManager 'MFR.GUI.Initializers.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Initializers-ComboBoxInitializer'></a>
## ComboBoxInitializer `type`

##### Namespace

MFR.GUI.Initializers

##### Summary

Declares methods that assist in initializing comboboxes.

<a name='M-MFR-GUI-Initializers-ComboBoxInitializer-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ComboBoxInitializer](#T-MFR-GUI-Initializers-ComboBoxInitializer 'MFR.GUI.Initializers.ComboBoxInitializer') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-GUI-Initializers-ComboBoxInitializer-AddCurrentItemToComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IList{System-String},System-String-'></a>
### AddCurrentItemToComboBox(comboBox,itemList,currentItem) `method`

##### Summary

Adds the `currentItem` to the drop-down portion of the
specified `comboBox` if it is not already present in the
provided `itemList`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') interface
that represents the combobox control to which the current item is to be added. |
| itemList | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | (Required.) Collection of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s), each of
which representing an item that is already present in the combobox. |
| currentItem | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to set as the
currently-selected item in the combobox (unless it is blank). |

##### Remarks

This method checks if the value of the `comboBox` parameter
is a `null` reference or refers to an already-disposed
control, and if the `currentItem` is `null`,
the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, or all whitespace.



If the specified `itemList` is `null` or the
empty collection, the specified `currentItem` is added to the
`comboBox`.



If the specified `currentItem` is not already in the item
list, it is added to the drop-down portion of the combobox.

<a name='M-MFR-GUI-Initializers-ComboBoxInitializer-AddItemsToComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IList{System-String}-'></a>
### AddItemsToComboBox(comboBox,itemList) `method`

##### Summary

Adds items from the provided list to the specified combobox.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') interface
that represents the combobox control to which items are to be added. |
| itemList | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | (Required.) Collection of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s), each of
which representing an item that is to be added to the drop-down portion of the
combobox. |

##### Remarks

This method iterates through the provided list of items and adds each non-null,
non-empty, and non-whitespace item to the combobox.



If this method receives a `null` reference or an
already-disposed combobox, then it simply returns without doing anything.



The same occurs if the paramref name="itemList" /> is `null`
or has no elements.

<a name='M-MFR-GUI-Initializers-ComboBoxInitializer-InitializeComboBox-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-Collections-Generic-IList{System-String},System-String-'></a>
### InitializeComboBox(comboBox,currentItem,itemList) `method`

##### Summary

Initializes a [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') to have
the specified `itemList` as the items in its
drop-down, and `currentItem` as the
currently-selected item.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') interface
that represents the combobox control that is to be initialized. |
| currentItem | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | (Optional.) String containing the value to set as the
currently-selected item in the combobox. |
| itemList | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Collection of one or more items that should be in the
history list of items in the combobox's body. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameters, `comboBox` and
`itemList`, are passed `null`
reference for values. |

##### Remarks

This method is intended to be utilized in order to fill combobox
controls with data from a data source.

<a name='M-MFR-GUI-Initializers-ComboBoxInitializer-SelectAppropriateItem-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox,System-String-'></a>
### SelectAppropriateItem(comboBox,currentItem) `method`

##### Summary

Selects the appropriate item in the combobox. If the
`currentItem` is not null, empty, or all whitespace, then set
the value of the editable, text portion of the combobox to it. Otherwise,
select the first item in the list, if there is one.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface.



This object is the combobox control that is to be initialized. |
| currentItem | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
represents the item that is either to be set as the text of the editable
portion of the target `comboBox`, or, if it is already
contained within the list of the item(s) in the combobox, selected. |

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
