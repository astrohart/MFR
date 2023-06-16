<a name='assembly'></a>
# MFR.GUI.Controls.Interfaces

## Contents

- [IDarkListBuilderControl](#T-MFR-GUI-Controls-Interfaces-IDarkListBuilderControl 'MFR.GUI.Controls.Interfaces.IDarkListBuilderControl')
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
