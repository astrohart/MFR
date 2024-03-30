<a name='assembly'></a>
# MFR.GUI.Controls

## Contents

- [EntryRespectingComboBox](#T-MFR-GUI-Controls-EntryRespectingComboBox 'MFR.GUI.Controls.EntryRespectingComboBox')
  - [EnteredText](#P-MFR-GUI-Controls-EntryRespectingComboBox-EnteredText 'MFR.GUI.Controls.EntryRespectingComboBox.EnteredText')
  - [GetEnteredText()](#M-MFR-GUI-Controls-EntryRespectingComboBox-GetEnteredText 'MFR.GUI.Controls.EntryRespectingComboBox.GetEnteredText')
  - [SetEnteredText(text)](#M-MFR-GUI-Controls-EntryRespectingComboBox-SetEnteredText-System-String- 'MFR.GUI.Controls.EntryRespectingComboBox.SetEnteredText(System.String)')
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
control," which seems to be the default behavior. This detrimental to
the software meeting certain requirements.  Therefore, this object was
engineered in the hopes of making that behavior go away.

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

<a name='M-MFR-GUI-Controls-EntryRespectingComboBox-GetEnteredText'></a>
### GetEnteredText() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that corresponds to the text entered into
this combo box by the user.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text
entered into the edit portion of the combo box by the user.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Controls-EntryRespectingComboBox-SetEnteredText-System-String-'></a>
### SetEnteredText(text) `method`

##### Summary

Sets the value of the
[EnteredText](#P-MFR-GUI-Controls-EntryRespectingComboBox-EnteredText 'MFR.GUI.Controls.EntryRespectingComboBox.EnteredText') property
to the specified `text`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the new value to set
for the property. |

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
