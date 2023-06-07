<a name='assembly'></a>
# MFR.GUI.Controls

## Contents

- [DarkDarkListBuilderControl](#T-MFR-GUI-Controls-DarkDarkListBuilderControl 'MFR.GUI.Controls.DarkDarkListBuilderControl')
  - [#ctor()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-#ctor 'MFR.GUI.Controls.DarkDarkListBuilderControl.#ctor')
  - [components](#F-MFR-GUI-Controls-DarkDarkListBuilderControl-components 'MFR.GUI.Controls.DarkDarkListBuilderControl.components')
  - [AddAllButtonEnabled](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonEnabled 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonEnabled')
  - [AddAllButtonText](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonText 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonText')
  - [AddAllButtonVisible](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonVisible 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonVisible')
  - [AddButtonEnabled](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonEnabled 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonEnabled')
  - [AddButtonText](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonText 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonText')
  - [AddButtonVisible](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonVisible 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonVisible')
  - [LeftListBox](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-LeftListBox 'MFR.GUI.Controls.DarkDarkListBuilderControl.LeftListBox')
  - [LeftListBoxLabel](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-LeftListBoxLabel 'MFR.GUI.Controls.DarkDarkListBuilderControl.LeftListBoxLabel')
  - [MoveDownButtonEnabled](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonEnabled 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonEnabled')
  - [MoveDownButtonText](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonText 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonText')
  - [MoveDownButtonVisible](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonVisible 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonVisible')
  - [MoveUpButtonEnabled](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonEnabled 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonEnabled')
  - [MoveUpButtonText](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonText 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonText')
  - [MoveUpButtonVisible](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonVisible 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonVisible')
  - [RemoveAllButtonEnabled](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonEnabled 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonEnabled')
  - [RemoveAllButtonText](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonText 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonText')
  - [RemoveAllButtonVisible](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonVisible 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonVisible')
  - [RemoveButtonEnabled](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonEnabled 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonEnabled')
  - [RemoveButtonText](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonText 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonText')
  - [RemoveButtonVisible](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonVisible 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonVisible')
  - [RightListBox](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RightListBox 'MFR.GUI.Controls.DarkDarkListBuilderControl.RightListBox')
  - [RightListBoxLabel](#P-MFR-GUI-Controls-DarkDarkListBuilderControl-RightListBoxLabel 'MFR.GUI.Controls.DarkDarkListBuilderControl.RightListBoxLabel')
  - [Dispose(disposing)](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-Dispose-System-Boolean- 'MFR.GUI.Controls.DarkDarkListBuilderControl.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-InitializeComponent 'MFR.GUI.Controls.DarkDarkListBuilderControl.InitializeComponent')
  - [OnAddAllButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddAllButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnAddAllButtonEnabledChanged')
  - [OnAddAllButtonTextChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddAllButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnAddAllButtonTextChanged')
  - [OnAddAllButtonVisibleChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddAllButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnAddAllButtonVisibleChanged')
  - [OnAddButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnAddButtonEnabledChanged')
  - [OnAddButtonTextChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnAddButtonTextChanged')
  - [OnAddButtonVisibleChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnAddButtonVisibleChanged')
  - [OnMoveDownButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveDownButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnMoveDownButtonEnabledChanged')
  - [OnMoveDownButtonTextChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveDownButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnMoveDownButtonTextChanged')
  - [OnMoveDownButtonVisibleChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveDownButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnMoveDownButtonVisibleChanged')
  - [OnMoveUpButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveUpButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnMoveUpButtonEnabledChanged')
  - [OnMoveUpButtonTextChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveUpButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnMoveUpButtonTextChanged')
  - [OnMoveUpButtonVisibleChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveUpButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnMoveUpButtonVisibleChanged')
  - [OnRemoveAllButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveAllButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnRemoveAllButtonEnabledChanged')
  - [OnRemoveAllButtonTextChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveAllButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnRemoveAllButtonTextChanged')
  - [OnRemoveAllButtonVisibleChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveAllButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnRemoveAllButtonVisibleChanged')
  - [OnRemoveButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnRemoveButtonEnabledChanged')
  - [OnRemoveButtonTextChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnRemoveButtonTextChanged')
  - [OnRemoveButtonVisibleChanged()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.OnRemoveButtonVisibleChanged')
  - [SubscribeEvents()](#M-MFR-GUI-Controls-DarkDarkListBuilderControl-SubscribeEvents 'MFR.GUI.Controls.DarkDarkListBuilderControl.SubscribeEvents')
- [EntryRespectingComboBox](#T-MFR-GUI-Controls-EntryRespectingComboBox 'MFR.GUI.Controls.EntryRespectingComboBox')
  - [_enteredText](#F-MFR-GUI-Controls-EntryRespectingComboBox-_enteredText 'MFR.GUI.Controls.EntryRespectingComboBox._enteredText')
  - [EnteredText](#P-MFR-GUI-Controls-EntryRespectingComboBox-EnteredText 'MFR.GUI.Controls.EntryRespectingComboBox.EnteredText')
  - [ClearSelection()](#M-MFR-GUI-Controls-EntryRespectingComboBox-ClearSelection 'MFR.GUI.Controls.EntryRespectingComboBox.ClearSelection')
  - [OnLeave(e)](#M-MFR-GUI-Controls-EntryRespectingComboBox-OnLeave-System-EventArgs- 'MFR.GUI.Controls.EntryRespectingComboBox.OnLeave(System.EventArgs)')
  - [OnSelectedIndexChanged(e)](#M-MFR-GUI-Controls-EntryRespectingComboBox-OnSelectedIndexChanged-System-EventArgs- 'MFR.GUI.Controls.EntryRespectingComboBox.OnSelectedIndexChanged(System.EventArgs)')
  - [OnTextChanged(e)](#M-MFR-GUI-Controls-EntryRespectingComboBox-OnTextChanged-System-EventArgs- 'MFR.GUI.Controls.EntryRespectingComboBox.OnTextChanged(System.EventArgs)')
- [FoldUnfoldButton](#T-MFR-GUI-Controls-FoldUnfoldButton 'MFR.GUI.Controls.FoldUnfoldButton')
  - [#ctor()](#M-MFR-GUI-Controls-FoldUnfoldButton-#ctor 'MFR.GUI.Controls.FoldUnfoldButton.#ctor')
  - [_isFolded](#F-MFR-GUI-Controls-FoldUnfoldButton-_isFolded 'MFR.GUI.Controls.FoldUnfoldButton._isFolded')
  - [FoldedText](#P-MFR-GUI-Controls-FoldUnfoldButton-FoldedText 'MFR.GUI.Controls.FoldUnfoldButton.FoldedText')
  - [FormFoldedSize](#P-MFR-GUI-Controls-FoldUnfoldButton-FormFoldedSize 'MFR.GUI.Controls.FoldUnfoldButton.FormFoldedSize')
  - [FormUnfoldedSize](#P-MFR-GUI-Controls-FoldUnfoldButton-FormUnfoldedSize 'MFR.GUI.Controls.FoldUnfoldButton.FormUnfoldedSize')
  - [IsFolded](#P-MFR-GUI-Controls-FoldUnfoldButton-IsFolded 'MFR.GUI.Controls.FoldUnfoldButton.IsFolded')
  - [UnfoldedText](#P-MFR-GUI-Controls-FoldUnfoldButton-UnfoldedText 'MFR.GUI.Controls.FoldUnfoldButton.UnfoldedText')
  - [OnClick(e)](#M-MFR-GUI-Controls-FoldUnfoldButton-OnClick-System-EventArgs- 'MFR.GUI.Controls.FoldUnfoldButton.OnClick(System.EventArgs)')
  - [OnFormFolded()](#M-MFR-GUI-Controls-FoldUnfoldButton-OnFormFolded-MFR-GUI-Controls-Events-FormFoldedEventArgs- 'MFR.GUI.Controls.FoldUnfoldButton.OnFormFolded(MFR.GUI.Controls.Events.FormFoldedEventArgs)')
  - [SetFoldedStateText()](#M-MFR-GUI-Controls-FoldUnfoldButton-SetFoldedStateText 'MFR.GUI.Controls.FoldUnfoldButton.SetFoldedStateText')
  - [ToggleFolded()](#M-MFR-GUI-Controls-FoldUnfoldButton-ToggleFolded 'MFR.GUI.Controls.FoldUnfoldButton.ToggleFolded')
- [Resources](#T-MFR-GUI-Controls-Properties-Resources 'MFR.GUI.Controls.Properties.Resources')
  - [Culture](#P-MFR-GUI-Controls-Properties-Resources-Culture 'MFR.GUI.Controls.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Controls-Properties-Resources-ResourceManager 'MFR.GUI.Controls.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Controls-DarkDarkListBuilderControl'></a>
## DarkDarkListBuilderControl `type`

##### Namespace

MFR.GUI.Controls

##### Summary

A [UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.UserControl 'System.Windows.Forms.UserControl') that is dark-themeable and
allows users to create a list of choices by adding one item at a time, and
optionally setting the list order.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[DarkDarkListBuilderControl](#T-MFR-GUI-Controls-DarkDarkListBuilderControl 'MFR.GUI.Controls.DarkDarkListBuilderControl') and returns a
reference to
it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Controls-DarkDarkListBuilderControl-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonEnabled'></a>
### AddAllButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonText'></a>
### AddAllButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonVisible'></a>
### AddAllButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonEnabled'></a>
### AddButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonText'></a>
### AddButtonText `property`

##### Summary

Gets or sets the `Add` button's text.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonVisible'></a>
### AddButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is visible.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-LeftListBox'></a>
### LeftListBox `property`

##### Summary

Gets a reference to the [DarkListBox](#T-xyLOGIX-UI-Dark-Controls-DarkListBox 'xyLOGIX.UI.Dark.Controls.DarkListBox')
that is displayed on the left-hand side of this user control.



Typically, this listbox displays available items.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-LeftListBoxLabel'></a>
### LeftListBoxLabel `property`

##### Summary

Gets a reference to the [DarkLabel](#T-xyLOGIX-UI-Dark-Controls-DarkLabel 'xyLOGIX.UI.Dark.Controls.DarkLabel')
that is above the left-hand listbox (typically, the left-hand listbox displays
available items).

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonEnabled'></a>
### MoveDownButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonText'></a>
### MoveDownButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonVisible'></a>
### MoveDownButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonEnabled'></a>
### MoveUpButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonText'></a>
### MoveUpButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonVisible'></a>
### MoveUpButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonEnabled'></a>
### RemoveAllButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonText'></a>
### RemoveAllButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonVisible'></a>
### RemoveAllButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonEnabled'></a>
### RemoveButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonText'></a>
### RemoveButtonText `property`

##### Summary

Gets or sets the button's text.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonVisible'></a>
### RemoveButtonVisible `property`

##### Summary

Gets or sets a value that indicates whether the button is
visible.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RightListBox'></a>
### RightListBox `property`

##### Summary

Gets a reference to the [DarkListBox](#T-xyLOGIX-UI-Dark-Controls-DarkListBox 'xyLOGIX.UI.Dark.Controls.DarkListBox')
that is displayed on the right-hand side of this user control.



Typically, this listbox displays available items.

<a name='P-MFR-GUI-Controls-DarkDarkListBuilderControl-RightListBoxLabel'></a>
### RightListBoxLabel `property`

##### Summary

Gets a reference to the [DarkLabel](#T-xyLOGIX-UI-Dark-Controls-DarkLabel 'xyLOGIX.UI.Dark.Controls.DarkLabel')
that is above the right-hand listbox (typically, the right-hand listbox
displays the list that the user is is building.
available items).

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify 
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddAllButtonEnabledChanged'></a>
### OnAddAllButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddAllButtonTextChanged'></a>
### OnAddAllButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddAllButtonVisibleChanged'></a>
### OnAddAllButtonVisibleChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-AddAllButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonVisibleChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddButtonEnabledChanged'></a>
### OnAddButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddButtonTextChanged'></a>
### OnAddButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnAddButtonVisibleChanged'></a>
### OnAddButtonVisibleChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-AddButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonVisibleChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveDownButtonEnabledChanged'></a>
### OnMoveDownButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveDownButtonTextChanged'></a>
### OnMoveDownButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveDownButtonVisibleChanged'></a>
### OnMoveDownButtonVisibleChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveDownButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonVisibleChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveUpButtonEnabledChanged'></a>
### OnMoveUpButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveUpButtonTextChanged'></a>
### OnMoveUpButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnMoveUpButtonVisibleChanged'></a>
### OnMoveUpButtonVisibleChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-MoveUpButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonVisibleChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveAllButtonEnabledChanged'></a>
### OnRemoveAllButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveAllButtonTextChanged'></a>
### OnRemoveAllButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveAllButtonVisibleChanged'></a>
### OnRemoveAllButtonVisibleChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveAllButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonVisibleChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveButtonEnabledChanged'></a>
### OnRemoveButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonEnabledChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveButtonTextChanged'></a>
### OnRemoveButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonTextChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-OnRemoveButtonVisibleChanged'></a>
### OnRemoveButtonVisibleChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkDarkListBuilderControl-RemoveButtonVisibleChanged 'MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonVisibleChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkDarkListBuilderControl-SubscribeEvents'></a>
### SubscribeEvents() `method`

##### Summary

Subscribes to the events of the component controls for rebroadcast to clients.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Controls-EntryRespectingComboBox'></a>
## EntryRespectingComboBox `type`

##### Namespace

MFR.GUI.Controls

##### Summary

Dropdown combo box that respects typed-in text entries.

##### Remarks

By "respects typed-in text entries," what we mean to say is, "does not
make a typed in text entry go away, or get replaced by an auto-correct
entry from the auto-suggest list, when the input focus leaves the
control," which seems to be the default behavior. This is detrimental to
the software meeting certain requirements.  Therefore, this object was
engineered in the hopes of making that behavior go away.

<a name='F-MFR-GUI-Controls-EntryRespectingComboBox-_enteredText'></a>
### _enteredText `constants`

##### Summary

String containing the text most recently typed into the editing
field of the ComboBox by the user.

<a name='P-MFR-GUI-Controls-EntryRespectingComboBox-EnteredText'></a>
### EnteredText `property`

##### Summary

Gets the text, verbatim, that was typed in the Combo Box's editing
field, by the user.

##### Remarks

This property only works for a
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox')
whose style is set to
[DropDown](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBoxStyle.DropDown 'System.Windows.Forms.ComboBoxStyle.DropDown')
. Otherwise,
it returns the value of the
[Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.Text 'System.Windows.Forms.ComboBox.Text')
property.

<a name='M-MFR-GUI-Controls-EntryRespectingComboBox-ClearSelection'></a>
### ClearSelection() `method`

##### Summary

Called to remove the selection highlight that persists on the text
in the edit portion of the control even after the selection is
changed or input focus leaves the control.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-EntryRespectingComboBox-OnLeave-System-EventArgs-'></a>
### OnLeave(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Control-Leave 'System.Windows.Forms.Control.Leave') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by saving off any text directly typed by the
user into the
[EnteredText](#P-MFR-GUI-Controls-EntryRespectingComboBox-EnteredText 'MFR.GUI.Controls.EntryRespectingComboBox.EnteredText')
property and adding that text to the list.

<a name='M-MFR-GUI-Controls-EntryRespectingComboBox-OnSelectedIndexChanged-System-EventArgs-'></a>
### OnSelectedIndexChanged(e) `method`

##### Summary

Raises the
[](#E-System-Windows-Forms-ComboBox-SelectedIndexChanged 'System.Windows.Forms.ComboBox.SelectedIndexChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by removing the highlight that persists in the
edit portion of the control after the selection has been changed.

<a name='M-MFR-GUI-Controls-EntryRespectingComboBox-OnTextChanged-System-EventArgs-'></a>
### OnTextChanged(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Control-TextChanged 'System.Windows.Forms.Control.TextChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='T-MFR-GUI-Controls-FoldUnfoldButton'></a>
## FoldUnfoldButton `type`

##### Namespace

MFR.GUI.Controls

##### Summary

Button that shows "More >>" or "Less <<" depending on
whether a form is folded or unfolded.

<a name='M-MFR-GUI-Controls-FoldUnfoldButton-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FoldUnfoldButton](#T-MFR-GUI-Controls-FoldUnfoldButton 'MFR.GUI.Controls.FoldUnfoldButton')
and returns a reference
to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Controls-FoldUnfoldButton-_isFolded'></a>
### _isFolded `constants`

##### Summary

Value indicating whether the containing form is to be in the folded state.

<a name='P-MFR-GUI-Controls-FoldUnfoldButton-FoldedText'></a>
### FoldedText `property`

##### Summary

Gets or sets the text that this button displays when the hosting
form is in the Folded state.

<a name='P-MFR-GUI-Controls-FoldUnfoldButton-FormFoldedSize'></a>
### FormFoldedSize `property`

##### Summary

Gets or sets the [Size](#T-Size 'Size') of the parent form when the
form is folded.

<a name='P-MFR-GUI-Controls-FoldUnfoldButton-FormUnfoldedSize'></a>
### FormUnfoldedSize `property`

##### Summary

Gets or sets the [Size](#T-Size 'Size') of the parent form when the
form is unfolded.

<a name='P-MFR-GUI-Controls-FoldUnfoldButton-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets or sets a value indicating whether the form is to be folded.

<a name='P-MFR-GUI-Controls-FoldUnfoldButton-UnfoldedText'></a>
### UnfoldedText `property`

##### Summary

Gets or sets the text that this button displays when the hosting
form is in the Folded state.

<a name='M-MFR-GUI-Controls-FoldUnfoldButton-OnClick-System-EventArgs-'></a>
### OnClick(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-MFR-GUI-Controls-FoldUnfoldButton-OnFormFolded-MFR-GUI-Controls-Events-FormFoldedEventArgs-'></a>
### OnFormFolded() `method`

##### Summary

Raises the [](#E-MFR-GUI-Controls-FoldUnfoldButton-Folded 'MFR.GUI.Controls.FoldUnfoldButton.Folded') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-FoldUnfoldButton-SetFoldedStateText'></a>
### SetFoldedStateText() `method`

##### Summary

Sets the [Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ButtonBase.Text 'System.Windows.Forms.ButtonBase.Text')
property of this button to correspond to whether the hosting form is
in the Folded state or not.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-FoldUnfoldButton-ToggleFolded'></a>
### ToggleFolded() `method`

##### Summary

Toggles the form between the folded and unfolded states.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Controls-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Controls.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Controls-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Controls-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
