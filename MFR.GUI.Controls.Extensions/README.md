<a name='assembly'></a>
# MFR.GUI.Controls.Extensions

## Contents

- [Resources](#T-MFR-GUI-Controls-Extensions-Properties-Resources 'MFR.GUI.Controls.Extensions.Properties.Resources')
  - [Culture](#P-MFR-GUI-Controls-Extensions-Properties-Resources-Culture 'MFR.GUI.Controls.Extensions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Controls-Extensions-Properties-Resources-ResourceManager 'MFR.GUI.Controls.Extensions.Properties.Resources.ResourceManager')
- [ToolStripComboBoxExtensions](#T-MFR-GUI-Controls-Extensions-ToolStripComboBoxExtensions 'MFR.GUI.Controls.Extensions.ToolStripComboBoxExtensions')
  - [SelectFirstItem(control)](#M-MFR-GUI-Controls-Extensions-ToolStripComboBoxExtensions-SelectFirstItem-System-Windows-Forms-ToolStripControlHost- 'MFR.GUI.Controls.Extensions.ToolStripComboBoxExtensions.SelectFirstItem(System.Windows.Forms.ToolStripControlHost)')
  - [SelectFirstItemNamed(control,name)](#M-MFR-GUI-Controls-Extensions-ToolStripComboBoxExtensions-SelectFirstItemNamed-System-Windows-Forms-ToolStripControlHost,System-String- 'MFR.GUI.Controls.Extensions.ToolStripComboBoxExtensions.SelectFirstItemNamed(System.Windows.Forms.ToolStripControlHost,System.String)')

<a name='T-MFR-GUI-Controls-Extensions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Controls.Extensions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Controls-Extensions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Controls-Extensions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-GUI-Controls-Extensions-ToolStripComboBoxExtensions'></a>
## ToolStripComboBoxExtensions `type`

##### Namespace

MFR.GUI.Controls.Extensions

##### Summary

Helper methods to allow us to use a
[ToolStripComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripComboBox 'System.Windows.Forms.ToolStripComboBox') control in a fluent
manner.

<a name='M-MFR-GUI-Controls-Extensions-ToolStripComboBoxExtensions-SelectFirstItem-System-Windows-Forms-ToolStripControlHost-'></a>
### SelectFirstItem(control) `method`

##### Summary

Selects the first item in the `control` specified.



Does nothing is the specified `control` contains no items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.ToolStripControlHost](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripControlHost 'System.Windows.Forms.ToolStripControlHost') | (Required.) The [ToolStripControlHost](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripControlHost 'System.Windows.Forms.ToolStripControlHost') to
operate on. |

<a name='M-MFR-GUI-Controls-Extensions-ToolStripComboBoxExtensions-SelectFirstItemNamed-System-Windows-Forms-ToolStripControlHost,System-String-'></a>
### SelectFirstItemNamed(control,name) `method`

##### Summary

Finds the first item in the list having the specified `name`;
if found, the item is selected.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.ToolStripControlHost](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripControlHost 'System.Windows.Forms.ToolStripControlHost') | (Required.) The
[ToolStripControlHost](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripControlHost 'System.Windows.Forms.ToolStripControlHost') to operate on. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to search for. |
