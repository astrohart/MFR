<a name='assembly'></a>
# MFR.GUI.Dialogs.Tests

## Contents

- [DialogTestBase](#T-MFR-GUI-Dialogs-Tests-DialogTestBase 'MFR.GUI.Dialogs.Tests.DialogTestBase')
  - [Cleanup()](#M-MFR-GUI-Dialogs-Tests-DialogTestBase-Cleanup 'MFR.GUI.Dialogs.Tests.DialogTestBase.Cleanup')
  - [Initialize()](#M-MFR-GUI-Dialogs-Tests-DialogTestBase-Initialize 'MFR.GUI.Dialogs.Tests.DialogTestBase.Initialize')
- [ProfileNameDialogTests](#T-MFR-GUI-Dialogs-Tests-ProfileNameDialogTests 'MFR.GUI.Dialogs.Tests.ProfileNameDialogTests')
  - [Test_AddNewProfile_Dialog_Works()](#M-MFR-GUI-Dialogs-Tests-ProfileNameDialogTests-Test_AddNewProfile_Dialog_Works 'MFR.GUI.Dialogs.Tests.ProfileNameDialogTests.Test_AddNewProfile_Dialog_Works')
  - [Test_SaveProfileAs_Dialog_Works()](#M-MFR-GUI-Dialogs-Tests-ProfileNameDialogTests-Test_SaveProfileAs_Dialog_Works 'MFR.GUI.Dialogs.Tests.ProfileNameDialogTests.Test_SaveProfileAs_Dialog_Works')
- [Resources](#T-MFR-GUI-Dialogs-Tests-Properties-Resources 'MFR.GUI.Dialogs.Tests.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Tests-Properties-Resources-Culture 'MFR.GUI.Dialogs.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Tests-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-Tests-DialogTestBase'></a>
## DialogTestBase `type`

##### Namespace

MFR.GUI.Dialogs.Tests

##### Summary

Defines the events, methods, properties, and behaviors for all test fixtures
that display forms and dialog boxes.

<a name='M-MFR-GUI-Dialogs-Tests-DialogTestBase-Cleanup'></a>
### Cleanup() `method`

##### Summary

Method that can be overriden by children of this class in order to do
processing once all tests have been completed.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-Tests-DialogTestBase-Initialize'></a>
### Initialize() `method`

##### Summary

Called prior to running any of the unit tests.

##### Parameters

This method has no parameters.

##### Remarks

The base class version of this method calls the
[EnableVisualStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Application.EnableVisualStyles 'System.Windows.Forms.Application.EnableVisualStyles') and
[SetCompatibleTextRenderingDefault](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Application.SetCompatibleTextRenderingDefault 'System.Windows.Forms.Application.SetCompatibleTextRenderingDefault')
methods in order to prepare the GUI of the forms and dialog boxes so it has a
modern look and feel.

<a name='T-MFR-GUI-Dialogs-Tests-ProfileNameDialogTests'></a>
## ProfileNameDialogTests `type`

##### Namespace

MFR.GUI.Dialogs.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProfileNameDialog](#T-MFR-GUI-Dialogs-ProfileNameDialog 'MFR.GUI.Dialogs.ProfileNameDialog') class.

<a name='M-MFR-GUI-Dialogs-Tests-ProfileNameDialogTests-Test_AddNewProfile_Dialog_Works'></a>
### Test_AddNewProfile_Dialog_Works() `method`

##### Summary

Tests that the New Profile Name dialog works when the operation that the user
wants to do is to add a new, blank profile.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-Tests-ProfileNameDialogTests-Test_SaveProfileAs_Dialog_Works'></a>
### Test_SaveProfileAs_Dialog_Works() `method`

##### Summary

Tests that the New Profile Name dialog works when the operation that the user
wants to do is to save a copy of the current Profile with a new name.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
