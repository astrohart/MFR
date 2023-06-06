<a name='assembly'></a>
# MFR.GUI.Controls

## Contents

- [DarkListBuilderControl](#T-MFR-GUI-Controls-DarkListBuilderControl 'MFR.GUI.Controls.DarkListBuilderControl')
  - [#ctor()](#M-MFR-GUI-Controls-DarkListBuilderControl-#ctor 'MFR.GUI.Controls.DarkListBuilderControl.#ctor')
  - [components](#F-MFR-GUI-Controls-DarkListBuilderControl-components 'MFR.GUI.Controls.DarkListBuilderControl.components')
  - [AddButtonEnabled](#P-MFR-GUI-Controls-DarkListBuilderControl-AddButtonEnabled 'MFR.GUI.Controls.DarkListBuilderControl.AddButtonEnabled')
  - [AddButtonText](#P-MFR-GUI-Controls-DarkListBuilderControl-AddButtonText 'MFR.GUI.Controls.DarkListBuilderControl.AddButtonText')
  - [LeftListBox](#P-MFR-GUI-Controls-DarkListBuilderControl-LeftListBox 'MFR.GUI.Controls.DarkListBuilderControl.LeftListBox')
  - [LeftListBoxLabel](#P-MFR-GUI-Controls-DarkListBuilderControl-LeftListBoxLabel 'MFR.GUI.Controls.DarkListBuilderControl.LeftListBoxLabel')
  - [RightListBox](#P-MFR-GUI-Controls-DarkListBuilderControl-RightListBox 'MFR.GUI.Controls.DarkListBuilderControl.RightListBox')
  - [RightListBoxLabel](#P-MFR-GUI-Controls-DarkListBuilderControl-RightListBoxLabel 'MFR.GUI.Controls.DarkListBuilderControl.RightListBoxLabel')
  - [Dispose(disposing)](#M-MFR-GUI-Controls-DarkListBuilderControl-Dispose-System-Boolean- 'MFR.GUI.Controls.DarkListBuilderControl.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Controls-DarkListBuilderControl-InitializeComponent 'MFR.GUI.Controls.DarkListBuilderControl.InitializeComponent')
  - [OnAddButtonEnabledChanged()](#M-MFR-GUI-Controls-DarkListBuilderControl-OnAddButtonEnabledChanged 'MFR.GUI.Controls.DarkListBuilderControl.OnAddButtonEnabledChanged')
  - [OnAddButtonTextChanged()](#M-MFR-GUI-Controls-DarkListBuilderControl-OnAddButtonTextChanged 'MFR.GUI.Controls.DarkListBuilderControl.OnAddButtonTextChanged')
  - [SubscribeEvents()](#M-MFR-GUI-Controls-DarkListBuilderControl-SubscribeEvents 'MFR.GUI.Controls.DarkListBuilderControl.SubscribeEvents')
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

<a name='T-MFR-GUI-Controls-DarkListBuilderControl'></a>
## DarkListBuilderControl `type`

##### Namespace

MFR.GUI.Controls

##### Summary

A [UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.UserControl 'System.Windows.Forms.UserControl') that is dark-themeable and
allows users to create a list of choices by adding one item at a time, and
optionally setting the list order.

<a name='M-MFR-GUI-Controls-DarkListBuilderControl-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[DarkListBuilderControl](#T-MFR-GUI-Controls-DarkListBuilderControl 'MFR.GUI.Controls.DarkListBuilderControl') and returns a
reference to
it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Controls-DarkListBuilderControl-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Controls-DarkListBuilderControl-AddButtonEnabled'></a>
### AddButtonEnabled `property`

##### Summary

Gets or sets a value tha indicates whether the button can be
selected.

<a name='P-MFR-GUI-Controls-DarkListBuilderControl-AddButtonText'></a>
### AddButtonText `property`

##### Summary

Gets or sets the `Add` button's text.

<a name='P-MFR-GUI-Controls-DarkListBuilderControl-LeftListBox'></a>
### LeftListBox `property`

##### Summary

Gets a reference to the [DarkListBox](#T-xyLOGIX-UI-Dark-Controls-DarkListBox 'xyLOGIX.UI.Dark.Controls.DarkListBox')
that is displayed on the left-hand side of this user control.



Typically, this listbox displays available items.

<a name='P-MFR-GUI-Controls-DarkListBuilderControl-LeftListBoxLabel'></a>
### LeftListBoxLabel `property`

##### Summary

Gets a reference to the [DarkLabel](#T-xyLOGIX-UI-Dark-Controls-DarkLabel 'xyLOGIX.UI.Dark.Controls.DarkLabel')
that is above the left-hand listbox (typically, the left-hand listbox displays
available items).

<a name='P-MFR-GUI-Controls-DarkListBuilderControl-RightListBox'></a>
### RightListBox `property`

##### Summary

Gets a reference to the [DarkListBox](#T-xyLOGIX-UI-Dark-Controls-DarkListBox 'xyLOGIX.UI.Dark.Controls.DarkListBox')
that is displayed on the right-hand side of this user control.



Typically, this listbox displays available items.

<a name='P-MFR-GUI-Controls-DarkListBuilderControl-RightListBoxLabel'></a>
### RightListBoxLabel `property`

##### Summary

Gets a reference to the [DarkLabel](#T-xyLOGIX-UI-Dark-Controls-DarkLabel 'xyLOGIX.UI.Dark.Controls.DarkLabel')
that is above the right-hand listbox (typically, the right-hand listbox
displays
available items).

<a name='M-MFR-GUI-Controls-DarkListBuilderControl-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Controls-DarkListBuilderControl-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify 
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkListBuilderControl-OnAddButtonEnabledChanged'></a>
### OnAddButtonEnabledChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkListBuilderControl-AddButtonEnabledChanged 'MFR.GUI.Controls.DarkListBuilderControl.AddButtonEnabledChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkListBuilderControl-OnAddButtonTextChanged'></a>
### OnAddButtonTextChanged() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Controls-DarkListBuilderControl-AddButtonTextChanged 'MFR.GUI.Controls.DarkListBuilderControl.AddButtonTextChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-DarkListBuilderControl-SubscribeEvents'></a>
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
