<a name='assembly'></a>
# MFR.GUI.Controls.Events

## Contents

- [FormFoldedEventArgs](#T-MFR-GUI-Controls-Events-FormFoldedEventArgs 'MFR.GUI.Controls.Events.FormFoldedEventArgs')
  - [#ctor(folded,size)](#M-MFR-GUI-Controls-Events-FormFoldedEventArgs-#ctor-System-Boolean,System-Drawing-Size- 'MFR.GUI.Controls.Events.FormFoldedEventArgs.#ctor(System.Boolean,System.Drawing.Size)')
  - [Folded](#P-MFR-GUI-Controls-Events-FormFoldedEventArgs-Folded 'MFR.GUI.Controls.Events.FormFoldedEventArgs.Folded')
  - [Size](#P-MFR-GUI-Controls-Events-FormFoldedEventArgs-Size 'MFR.GUI.Controls.Events.FormFoldedEventArgs.Size')
- [FormFoldedEventHandler](#T-MFR-GUI-Controls-Events-FormFoldedEventHandler 'MFR.GUI.Controls.Events.FormFoldedEventHandler')
- [ListBuidlerEventArgs](#T-MFR-GUI-Controls-Events-ListBuidlerEventArgs 'MFR.GUI.Controls.Events.ListBuidlerEventArgs')
  - [#ctor(side)](#M-MFR-GUI-Controls-Events-ListBuidlerEventArgs-#ctor-MFR-GUI-Controls-Constants-ListBuilderSide- 'MFR.GUI.Controls.Events.ListBuidlerEventArgs.#ctor(MFR.GUI.Controls.Constants.ListBuilderSide)')
  - [Side](#P-MFR-GUI-Controls-Events-ListBuidlerEventArgs-Side 'MFR.GUI.Controls.Events.ListBuidlerEventArgs.Side')
- [ListBuilderCancelEventArgs](#T-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs 'MFR.GUI.Controls.Events.ListBuilderCancelEventArgs')
  - [#ctor(side)](#M-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs-#ctor-MFR-GUI-Controls-Constants-ListBuilderSide- 'MFR.GUI.Controls.Events.ListBuilderCancelEventArgs.#ctor(MFR.GUI.Controls.Constants.ListBuilderSide)')
  - [Side](#P-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs-Side 'MFR.GUI.Controls.Events.ListBuilderCancelEventArgs.Side')
- [ListBuilderCancelEventHandler](#T-MFR-GUI-Controls-Events-ListBuilderCancelEventHandler 'MFR.GUI.Controls.Events.ListBuilderCancelEventHandler')
- [ListBuilderEventHandler](#T-MFR-GUI-Controls-Events-ListBuilderEventHandler 'MFR.GUI.Controls.Events.ListBuilderEventHandler')
- [Resources](#T-MFR-GUI-Controls-Events-Properties-Resources 'MFR.GUI.Controls.Events.Properties.Resources')
  - [Culture](#P-MFR-GUI-Controls-Events-Properties-Resources-Culture 'MFR.GUI.Controls.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Controls-Events-Properties-Resources-ResourceManager 'MFR.GUI.Controls.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Controls-Events-FormFoldedEventArgs'></a>
## FormFoldedEventArgs `type`

##### Namespace

MFR.GUI.Controls.Events

##### Summary

Contains information for a Folded event.

<a name='M-MFR-GUI-Controls-Events-FormFoldedEventArgs-#ctor-System-Boolean,System-Drawing-Size-'></a>
### #ctor(folded,size) `constructor`

##### Summary

Constructs a new instance of [FoldedEventArgs](#T-MFR-FoldedEventArgs 'MFR.FoldedEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | New folded state of the parent form. |
| size | [System.Drawing.Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') | New size of the parent form. |

<a name='P-MFR-GUI-Controls-Events-FormFoldedEventArgs-Folded'></a>
### Folded `property`

##### Summary

Gets the new folded state of the parent form.

<a name='P-MFR-GUI-Controls-Events-FormFoldedEventArgs-Size'></a>
### Size `property`

##### Summary

Gets the new size of the parent form.

<a name='T-MFR-GUI-Controls-Events-FormFoldedEventHandler'></a>
## FormFoldedEventHandler `type`

##### Namespace

MFR.GUI.Controls.Events

##### Summary

Provides the method signature for the handler of a FormFolded event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Controls.Events.FormFoldedEventHandler](#T-T-MFR-GUI-Controls-Events-FormFoldedEventHandler 'T:MFR.GUI.Controls.Events.FormFoldedEventHandler') | The sender of the event. |

<a name='T-MFR-GUI-Controls-Events-ListBuidlerEventArgs'></a>
## ListBuidlerEventArgs `type`

##### Namespace

MFR.GUI.Controls.Events

##### Summary

Arguments for a `ListBuilderEventHandler`-style event.

<a name='M-MFR-GUI-Controls-Events-ListBuidlerEventArgs-#ctor-MFR-GUI-Controls-Constants-ListBuilderSide-'></a>
### #ctor(side) `constructor`

##### Summary

Constructs a new instance of
[ListBuidlerEventArgs](#T-MFR-GUI-Controls-Events-ListBuidlerEventArgs 'MFR.GUI.Controls.Events.ListBuidlerEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| side | [MFR.GUI.Controls.Constants.ListBuilderSide](#T-MFR-GUI-Controls-Constants-ListBuilderSide 'MFR.GUI.Controls.Constants.ListBuilderSide') | (Required.) One of the
[ListBuilderSide](#T-MFR-GUI-Controls-Constants-ListBuilderSide 'MFR.GUI.Controls.Constants.ListBuilderSide') values that
indicates on which side of the list-builder control did the user last act. |

<a name='P-MFR-GUI-Controls-Events-ListBuidlerEventArgs-Side'></a>
### Side `property`

##### Summary

Gets a [ListBuilderSide](#T-MFR-GUI-Controls-Constants-ListBuilderSide 'MFR.GUI.Controls.Constants.ListBuilderSide') enumeration
value that indicates on which side of the list-builder control did the user
act.

<a name='T-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs'></a>
## ListBuilderCancelEventArgs `type`

##### Namespace

MFR.GUI.Controls.Events

##### Summary

Arguments for a cancellable event that is raised by a list-builder control.

<a name='M-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs-#ctor-MFR-GUI-Controls-Constants-ListBuilderSide-'></a>
### #ctor(side) `constructor`

##### Summary

Constructs a new instance of
[ListBuilderCancelEventArgs](#T-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs 'MFR.GUI.Controls.Events.ListBuilderCancelEventArgs') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| side | [MFR.GUI.Controls.Constants.ListBuilderSide](#T-MFR-GUI-Controls-Constants-ListBuilderSide 'MFR.GUI.Controls.Constants.ListBuilderSide') | (Required.) One of the
[ListBuilderSide](#T-MFR-GUI-Controls-Constants-ListBuilderSide 'MFR.GUI.Controls.Constants.ListBuilderSide') values that
indicates on which side of the list-builder control did the user last act. |

<a name='P-MFR-GUI-Controls-Events-ListBuilderCancelEventArgs-Side'></a>
### Side `property`

##### Summary

Gets a [ListBuilderSide](#T-MFR-GUI-Controls-Constants-ListBuilderSide 'MFR.GUI.Controls.Constants.ListBuilderSide') enumeration
value that indicates on which side of the list-builder control did the user
act.

<a name='T-MFR-GUI-Controls-Events-ListBuilderCancelEventHandler'></a>
## ListBuilderCancelEventHandler `type`

##### Namespace

MFR.GUI.Controls.Events

##### Summary

Handler for a cancellable event that occurs with respect to either the
left-hand side or right-hand side of a list-builder control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Controls.Events.ListBuilderCancelEventHandler](#T-T-MFR-GUI-Controls-Events-ListBuilderCancelEventHandler 'T:MFR.GUI.Controls.Events.ListBuilderCancelEventHandler') | (Required.) Reference to the object that raised the event. |

<a name='T-MFR-GUI-Controls-Events-ListBuilderEventHandler'></a>
## ListBuilderEventHandler `type`

##### Namespace

MFR.GUI.Controls.Events

##### Summary

Handler for an event that occurs with respect to either the left-hand side or the right-hand side of a list-builder control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Controls.Events.ListBuilderEventHandler](#T-T-MFR-GUI-Controls-Events-ListBuilderEventHandler 'T:MFR.GUI.Controls.Events.ListBuilderEventHandler') | (Required.) Reference to the object that raised the event. |

<a name='T-MFR-GUI-Controls-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Controls.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Controls-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Controls-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
