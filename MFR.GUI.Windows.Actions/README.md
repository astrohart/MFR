<a name='assembly'></a>
# MFR.GUI.Windows.Actions

## Contents

- [Compute](#T-MFR-GUI-Windows-Actions-Compute 'MFR.GUI.Windows.Actions.Compute')
  - [ScaledComponentValue(componentValue,multiplicationFactor)](#M-MFR-GUI-Windows-Actions-Compute-ScaledComponentValue-System-Int32,System-Single- 'MFR.GUI.Windows.Actions.Compute.ScaledComponentValue(System.Int32,System.Single)')
- [Display](#T-MFR-GUI-Windows-Actions-Display 'MFR.GUI.Windows.Actions.Display')
  - [#cctor()](#M-MFR-GUI-Windows-Actions-Display-#cctor 'MFR.GUI.Windows.Actions.Display.#cctor')
  - [ConfirmWithYesNo(parentForm,message,defaultButton)](#M-MFR-GUI-Windows-Actions-Display-ConfirmWithYesNo-xyLOGIX-Core-Extensions-IForm,System-String,System-Windows-Forms-MessageBoxDefaultButton- 'MFR.GUI.Windows.Actions.Display.ConfirmWithYesNo(xyLOGIX.Core.Extensions.IForm,System.String,System.Windows.Forms.MessageBoxDefaultButton)')
  - [StopError(parentForm,message)](#M-MFR-GUI-Windows-Actions-Display-StopError-xyLOGIX-Core-Extensions-IForm,System-String- 'MFR.GUI.Windows.Actions.Display.StopError(xyLOGIX.Core.Extensions.IForm,System.String)')
- [Get](#T-MFR-GUI-Windows-Actions-Get 'MFR.GUI.Windows.Actions.Get')
  - [DesignTimeScreenHeight()](#M-MFR-GUI-Windows-Actions-Get-DesignTimeScreenHeight 'MFR.GUI.Windows.Actions.Get.DesignTimeScreenHeight')
  - [DesignTimeScreenWidth()](#M-MFR-GUI-Windows-Actions-Get-DesignTimeScreenWidth 'MFR.GUI.Windows.Actions.Get.DesignTimeScreenWidth')
  - [ReferenceScreenBounds(control)](#M-MFR-GUI-Windows-Actions-Get-ReferenceScreenBounds-System-Windows-Forms-Control- 'MFR.GUI.Windows.Actions.Get.ReferenceScreenBounds(System.Windows.Forms.Control)')
- [Is](#T-MFR-GUI-Windows-Actions-Is 'MFR.GUI.Windows.Actions.Is')
  - [TargetFolderMatchingReplaceWith(pathname,replaceWith)](#M-MFR-GUI-Windows-Actions-Is-TargetFolderMatchingReplaceWith-System-String,System-String- 'MFR.GUI.Windows.Actions.Is.TargetFolderMatchingReplaceWith(System.String,System.String)')
- [Resources](#T-MFR-GUI-Windows-Actions-Properties-Resources 'MFR.GUI.Windows.Actions.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Actions-Properties-Resources-Culture 'MFR.GUI.Windows.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Actions-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Actions.Properties.Resources.ResourceManager')
- [Responsive](#T-MFR-GUI-Windows-Actions-Responsive 'MFR.GUI.Windows.Actions.Responsive')
  - [#ctor()](#M-MFR-GUI-Windows-Actions-Responsive-#ctor-System-Drawing-Rectangle- 'MFR.GUI.Windows.Actions.Responsive.#ctor(System.Drawing.Rectangle)')
  - [_designTimeHeight](#F-MFR-GUI-Windows-Actions-Responsive-_designTimeHeight 'MFR.GUI.Windows.Actions.Responsive._designTimeHeight')
  - [_designTimeWidth](#F-MFR-GUI-Windows-Actions-Responsive-_designTimeWidth 'MFR.GUI.Windows.Actions.Responsive._designTimeWidth')
  - [_heightMultiplicationFactor](#F-MFR-GUI-Windows-Actions-Responsive-_heightMultiplicationFactor 'MFR.GUI.Windows.Actions.Responsive._heightMultiplicationFactor')
  - [_widthMultiplicationFactor](#F-MFR-GUI-Windows-Actions-Responsive-_widthMultiplicationFactor 'MFR.GUI.Windows.Actions.Responsive._widthMultiplicationFactor')
  - [Resolution](#P-MFR-GUI-Windows-Actions-Responsive-Resolution 'MFR.GUI.Windows.Actions.Responsive.Resolution')
- [Would](#T-MFR-GUI-Windows-Actions-Would 'MFR.GUI.Windows.Actions.Would')
  - [UserOverwriteExistingDirectory(rootFolderPath,replaceWith)](#M-MFR-GUI-Windows-Actions-Would-UserOverwriteExistingDirectory-System-String,System-String- 'MFR.GUI.Windows.Actions.Would.UserOverwriteExistingDirectory(System.String,System.String)')

<a name='T-MFR-GUI-Windows-Actions-Compute'></a>
## Compute `type`

##### Namespace

MFR.GUI.Windows.Actions

##### Summary

Exposes static methods to compute the value of certain quantities.

<a name='M-MFR-GUI-Windows-Actions-Compute-ScaledComponentValue-System-Int32,System-Single-'></a>
### ScaledComponentValue(componentValue,multiplicationFactor) `method`

##### Summary

Computes the scaled value for a form's width or height.

##### Returns

A [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value that is set to the mathematical
floor of the product of `componentValue` and
`multiplicationFactor`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| componentValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) The value to be scaled. |
| multiplicationFactor | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | (Required.) The scaling factor to be used. |

<a name='T-MFR-GUI-Windows-Actions-Display'></a>
## Display `type`

##### Namespace

MFR.GUI.Windows.Actions

##### Summary

Expose static methods to show data and messages to the interactive user.

##### Remarks

The methods of this class are designed to be used to ensure that
information, data, and/or messages are displayed on the UI thread.

<a name='M-MFR-GUI-Windows-Actions-Display-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Display](#T-MFR-GUI-Windows-Actions-Display 'MFR.GUI.Windows.Actions.Display') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-GUI-Windows-Actions-Display-ConfirmWithYesNo-xyLOGIX-Core-Extensions-IForm,System-String,System-Windows-Forms-MessageBoxDefaultButton-'></a>
### ConfirmWithYesNo(parentForm,message,defaultButton) `method`

##### Summary

Displays a message box that asks the user a Yes/No question, and
returns a [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
describes the choice selected.



The button has the input focus upon display of the message box by
default, but this can be changed by supplying one of the
[MessageBoxDefaultButton](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MessageBoxDefaultButton 'System.Windows.Forms.MessageBoxDefaultButton') values for the
`defaultButton` parameter.

##### Returns

The [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the button clicked by the user.



If the button is clicked, then
[Yes](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult.Yes 'System.Windows.Forms.DialogResult.Yes') is returned.



If the button is clicked, then
[No](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult.No 'System.Windows.Forms.DialogResult.No') is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentForm | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | (Required.) Reference to an instance of an object that
implements the [IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') interface.



This object represents the parent (owner) window of the message box.



If `null` is passed to this method, then the overload of this
method that does not accept this parameter is called, and the resulting message
box is displayed without an owner window. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the message to be
displayed. |
| defaultButton | [System.Windows.Forms.MessageBoxDefaultButton](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MessageBoxDefaultButton 'System.Windows.Forms.MessageBoxDefaultButton') | (Required.) One of the
[MessageBoxDefaultButton](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MessageBoxDefaultButton 'System.Windows.Forms.MessageBoxDefaultButton') values that
specifies which button is to have the input focus by default.



This parameter is set to
[Button2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MessageBoxDefaultButton.Button2 'System.Windows.Forms.MessageBoxDefaultButton.Button2') if not
specified by the caller. |

<a name='M-MFR-GUI-Windows-Actions-Display-StopError-xyLOGIX-Core-Extensions-IForm,System-String-'></a>
### StopError(parentForm,message) `method`

##### Summary

Shows a `Stop` message to the user, usually to indicate a fatal error that
prevents further successful application execution.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentForm | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | (Required.) Reference to an instance of an object that implements the
[IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') interface representing the
parent, or owner, form of the message box that will be displayed. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a message that is to be
displayed. |

##### Remarks

This method ensures that the message is displayed on the UI thread.



If the argument of the `parentForm` is a
`null` reference, or if the `message` is
blank, then this method takes no action.

<a name='T-MFR-GUI-Windows-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.GUI.Windows.Actions

##### Summary

Exposes static methods to obtain various quantities.

<a name='M-MFR-GUI-Windows-Actions-Get-DesignTimeScreenHeight'></a>
### DesignTimeScreenHeight() `method`

##### Summary

Attempts to load the value of the `DESIGN_TIME_SCREEN_HEIGHT` metric from
the `app.config` file.

##### Returns

If successful, the value of the `DESIGN_TIME_SCREEN_HEIGHT`
metric from the `app.config` file; otherwise zero..

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Actions-Get-DesignTimeScreenWidth'></a>
### DesignTimeScreenWidth() `method`

##### Summary

Attempts to load the value of the `DESIGN_TIME_SCREEN_WIDTH` metric from
the `app.config` file.

##### Returns

If successful, the value of the `DESIGN_TIME_SCREEN_WIDTH`
metric from the `app.config` file; otherwise zero..

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Actions-Get-ReferenceScreenBounds-System-Windows-Forms-Control-'></a>
### ReferenceScreenBounds(control) `method`

##### Summary

Gets a [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that expresses the bounds of
the first element of the
[AllScreens](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Screen.AllScreens 'System.Windows.Forms.Screen.AllScreens') list --- which, itself,
represents the set of all monitors that the user has connected to this machine.

##### Returns

If successful, a [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that expresses the
bounds of the first element of the
[AllScreens](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Screen.AllScreens 'System.Windows.Forms.Screen.AllScreens') list --- which, itself,
represents the set of all monitors that the user has connected to this machine;
otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle.Empty 'System.Drawing.Rectangle.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Optional.) A [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that is on the
screen that you wish to get the bounds for.



The default value of this property is `null`.  In that event,
then the method finds the first screen in the list, and returns its bounds. |

<a name='T-MFR-GUI-Windows-Actions-Is'></a>
## Is `type`

##### Namespace

MFR.GUI.Windows.Actions

##### Summary

Exposes static methods to determine whether certain circumstances are true in regard to presently-held data.

<a name='M-MFR-GUI-Windows-Actions-Is-TargetFolderMatchingReplaceWith-System-String,System-String-'></a>
### TargetFolderMatchingReplaceWith(pathname,replaceWith) `method`

##### Summary

Determines whether the name of the folder having the specified
`pathname`, along with the name of the `.csproj` file
that we assume is within said folder, is identically equal to the specified
`replaceWith` text.

##### Returns

`true` if the names match; `false`
otherwise, or if a required folder or file doesn't exist.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder in the directory tree of the starting folder. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the text to replace the search value with. |

<a name='T-MFR-GUI-Windows-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-GUI-Windows-Actions-Responsive'></a>
## Responsive `type`

##### Namespace

MFR.GUI.Windows.Actions

##### Summary

Exposes methods and properties to support design of responsive forms, i.e.,
Windows Forms that automatically resize and rescale themselves when they are
dragged from a monitor with one screen resolution to another monitor having a
different screen resolution.

<a name='M-MFR-GUI-Windows-Actions-Responsive-#ctor-System-Drawing-Rectangle-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[Responsive](#T-MFR-GUI-Windows-Actions-Responsive 'MFR.GUI.Windows.Actions.Responsive') and returns a reference to
it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Windows-Actions-Responsive-_designTimeHeight'></a>
### _designTimeHeight `constants`

##### Summary

A [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') value that contains the value of the
`DESIGN_TIME_SCREEN_HEIGHT` metric from the `app.config` file, or
zero if not found.

<a name='F-MFR-GUI-Windows-Actions-Responsive-_designTimeWidth'></a>
### _designTimeWidth `constants`

##### Summary

A [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') value that contains the value of the
`DESIGN_TIME_SCREEN_WIDTH` metric from the `app.config` file, or
zero if not found.

<a name='F-MFR-GUI-Windows-Actions-Responsive-_heightMultiplicationFactor'></a>
### _heightMultiplicationFactor `constants`

##### Summary

A [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') value that contains the multiplication factor
for responsive heights.

<a name='F-MFR-GUI-Windows-Actions-Responsive-_widthMultiplicationFactor'></a>
### _widthMultiplicationFactor `constants`

##### Summary

A [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') value that contains the multiplication factor
for responsive widths.

<a name='P-MFR-GUI-Windows-Actions-Responsive-Resolution'></a>
### Resolution `property`

##### Summary

Gets a [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that displays the resolution
of the current monitor.

<a name='T-MFR-GUI-Windows-Actions-Would'></a>
## Would `type`

##### Namespace

MFR.GUI.Windows.Actions

##### Summary

Exposes static methods to explore hypothetical situations with data.

<a name='M-MFR-GUI-Windows-Actions-Would-UserOverwriteExistingDirectory-System-String,System-String-'></a>
### UserOverwriteExistingDirectory(rootFolderPath,replaceWith) `method`

##### Summary

Determines whether the user would accidentally nuke an existing folder or
project in their root directory tree by proceeding, given the specified
`rootFolderPath` and the specified
`replaceWith` text.

##### Returns

`true` if the user stands a chance of nuking existing
changes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder in which the user desires the operation(s) to start. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to replace all occurrences of the
`Find What` text with. |
