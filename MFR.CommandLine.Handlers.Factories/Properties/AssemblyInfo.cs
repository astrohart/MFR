using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MFR.CommandLine.Handlers.Factories")]
[assembly: AssemblyDescription("Provides objects and functionality to handle the various use-cases when invalid input is sent over the command line; either a root directory is blank or missing, does not contain .sln file(s) in its directory tree, or there are multiple instance(s) of Visual Studio open but none of them have the Solution(s) found in the target directory tree, loaded.  We want to develop various user-assistance strategy(ies) to help the user with these use-cases.  This particular library holds the factories for this component.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("xyLOGIX, LLC")]
[assembly: AssemblyProduct("xyLOGIX Project File Renamer")]
[assembly:
    AssemblyCopyright(
        "Copyright © 2021-25 by xyLOGIX, LLC.  All rights reserved.")]
[assembly:
    AssemblyTrademark(
        "This software is a component of xyLOGIX Project File Renamer.  Project File Renamer is a trademark of xyLOGIX, LLC.  All rights reserved, especially those granted by international treaties.  Other brand names, brands, logos, service marks, trademarks, and registered trademarks herein belong to their respective owners.")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e0ede07e-e4f7-448a-aaf8-bd04c96bb590")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]