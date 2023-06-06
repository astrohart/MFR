<a name='assembly'></a>
# MFR.GUI.Controls.Interfaces

## Contents

- [IDarkListBuilderControl](#T-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl')
  - [AddAllButtonEnabled](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddAllButtonEnabled 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddAllButtonEnabled')
  - [AddAllButtonText](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddAllButtonText 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddAllButtonText')
  - [AddAllButtonVisible](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddAllButtonVisible 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddAllButtonVisible')
  - [AddButtonEnabled](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddButtonEnabled 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddButtonEnabled')
  - [AddButtonText](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddButtonText 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddButtonText')
  - [AddButtonVisible](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddButtonVisible 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddButtonVisible')
  - [LeftListBox](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-LeftListBox 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.LeftListBox')
  - [LeftListBoxLabel](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-LeftListBoxLabel 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.LeftListBoxLabel')
  - [MoveDownButtonEnabled](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveDownButtonEnabled 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveDownButtonEnabled')
  - [MoveDownButtonText](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveDownButtonText 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveDownButtonText')
  - [MoveDownButtonVisible](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveDownButtonVisible 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveDownButtonVisible')
  - [MoveUpButtonEnabled](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveUpButtonEnabled 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveUpButtonEnabled')
  - [MoveUpButtonText](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveUpButtonText 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveUpButtonText')
  - [MoveUpButtonVisible](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveUpButtonVisible 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveUpButtonVisible')
  - [RemoveAllButtonEnabled](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveAllButtonEnabled 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveAllButtonEnabled')
  - [RemoveAllButtonText](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveAllButtonText 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveAllButtonText')
  - [RemoveAllButtonVisible](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveAllButtonVisible 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveAllButtonVisible')
  - [RemoveButtonEnabled](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveButtonEnabled 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveButtonEnabled')
  - [RemoveButtonText](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveButtonText 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveButtonText')
  - [RemoveButtonVisible](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveButtonVisible 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveButtonVisible')
  - [RightListBox](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RightListBox 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RightListBox')
  - [RightListBoxLabel](#P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RightListBoxLabel 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RightListBoxLabel')
- [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
  - [EnteredText](#P-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-EnteredText 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox.EnteredText')
- [IFoldUnfoldButton](#T-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton')
  - [FoldedText](#P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-FoldedText 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton.FoldedText')
  - [FormFoldedSize](#P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-FormFoldedSize 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton.FormFoldedSize')
  - [FormUnfoldedSize](#P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-FormUnfoldedSize 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton.FormUnfoldedSize')
  - [IsFolded](#P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-IsFolded 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton.IsFolded')
  - [UnfoldedText](#P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-UnfoldedText 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton.UnfoldedText')
  - [SetFoldedStateText()](#M-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-SetFoldedStateText 'MFR.GUI.Controls.Interfaces.IFoldUnfoldButton.SetFoldedStateText')
- [Resources](#T-MFR-GUI-Controls-Interfaces-Properties-Resources 'MFR.GUI.Controls.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Controls-Interfaces-Properties-Resources-Culture 'MFR.GUI.Controls.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Controls-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Controls.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl'></a>
## IDarkListBuilderControl `type`

##### Namespace

MFR.GUI.Controls.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a list-builder control
that allows users to create a list of choices by adding one item at a time, and
optionally setting the list order..

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddAllButtonEnabled'></a>
### AddAllButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddAllButtonText'></a>
### AddAllButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddAllButtonVisible'></a>
### AddAllButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddButtonEnabled'></a>
### AddButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddButtonText'></a>
### AddButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-AddButtonVisible'></a>
### AddButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is visible.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-LeftListBox'></a>
### LeftListBox `property`

##### Summary

Gets a reference to the [DarkListBox](#T-xyLOGIX-UI-Dark-Controls-DarkListBox 'xyLOGIX.UI.Dark.Controls.DarkListBox')
that is displayed on the left-hand side of this user control.



Typically, this listbox displays available items.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-LeftListBoxLabel'></a>
### LeftListBoxLabel `property`

##### Summary

Gets a reference to the [DarkLabel](#T-xyLOGIX-UI-Dark-Controls-DarkLabel 'xyLOGIX.UI.Dark.Controls.DarkLabel')
that is above the left-hand listbox (typically, the left-hand listbox displays
available items).

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveDownButtonEnabled'></a>
### MoveDownButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveDownButtonText'></a>
### MoveDownButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveDownButtonVisible'></a>
### MoveDownButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveUpButtonEnabled'></a>
### MoveUpButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveUpButtonText'></a>
### MoveUpButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-MoveUpButtonVisible'></a>
### MoveUpButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveAllButtonEnabled'></a>
### RemoveAllButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveAllButtonText'></a>
### RemoveAllButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveAllButtonVisible'></a>
### RemoveAllButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveButtonEnabled'></a>
### RemoveButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveButtonText'></a>
### RemoveButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RemoveButtonVisible'></a>
### RemoveButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RightListBox'></a>
### RightListBox `property`

##### Summary

Gets a reference to the [DarkListBox](#T-xyLOGIX-UI-Dark-Controls-DarkListBox 'xyLOGIX.UI.Dark.Controls.DarkListBox')
that is displayed on the right-hand side of this user control.



Typically, this listbox displays available items.

<a name='P-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl-RightListBoxLabel'></a>
### RightListBoxLabel `property`

##### Summary

Gets a reference to the [DarkLabel](#T-xyLOGIX-UI-Dark-Controls-DarkLabel 'xyLOGIX.UI.Dark.Controls.DarkLabel')
that is above the right-hand listbox (typically, the right-hand listbox
displays
available items).

<a name='T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox'></a>
## IEntryRespectingComboBox `type`

##### Namespace

MFR.GUI.Controls.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a combo box
control that maintains the text that is manually typed in to the edit
box portion of the drop down by the user, instead of throwing it away
when the control loses the input focus..

<a name='P-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-EnteredText'></a>
### EnteredText `property`

##### Summary

Gets the text, verbatim, that was typed in the Combo Box's editing
field, by the user.

##### Remarks

This property only works for a [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') whose style is set to [DropDown](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBoxStyle.DropDown 'System.Windows.Forms.ComboBoxStyle.DropDown') . Otherwise,
it returns the value of the [Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.Text 'System.Windows.Forms.ComboBox.Text') property.

<a name='T-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton'></a>
## IFoldUnfoldButton `type`

##### Namespace

MFR.GUI.Controls.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a button that
folds and unfolds its parent form.

<a name='P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-FoldedText'></a>
### FoldedText `property`

##### Summary

Gets or sets the text that this button displays when the hosting
form is in the Folded state.

<a name='P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-FormFoldedSize'></a>
### FormFoldedSize `property`

##### Summary

Gets or sets the [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') of the parent
form when the form is folded.

<a name='P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-FormUnfoldedSize'></a>
### FormUnfoldedSize `property`

##### Summary

Gets or sets the [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') of the parent
form when the form is unfolded.

<a name='P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets or sets a value indicating whether the form is to be folded.

<a name='P-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-UnfoldedText'></a>
### UnfoldedText `property`

##### Summary

Gets or sets the text that this button displays when the hosting
form is in the Folded state.

<a name='M-MFR-GUI-Controls-Interfaces-IFoldUnfoldButton-SetFoldedStateText'></a>
### SetFoldedStateText() `method`

##### Summary

Sets the [Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ButtonBase.Text 'System.Windows.Forms.ButtonBase.Text')
property of this button to correspond to whether the hosting form is
in the Folded state or not.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Controls-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Controls.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Controls-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Controls-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
