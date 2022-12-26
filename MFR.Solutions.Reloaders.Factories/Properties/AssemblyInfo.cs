using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("xyLOGIX Factories Support Library for Project File Renamer's Solution Reloaders Component")]
[assembly: AssemblyDescription("Provides objects and functionality to track the open Visual Studio Solution (*.sln) files loaded in various instances of Visual Studio, and to close and open them in the Visual Studio instances that have them open.  The thinking is that the file renaming and find/replace operations that are requested cannot take place unless the corresopnding Visual Studio Solution is not open in an instance of Visual Studio. However, this being said, we want to keep track of which solutions were open in what instance of Visual Studio, in case the user specifies that all Solutions closed by the application are to be reopened upon completion of the processing.  This particular library holds the factories for this component.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("xyLOGIX, LLC")]
[assembly: AssemblyProduct("xyLOGIX Support Library for Project File Renamer")]
[assembly:
    AssemblyCopyright(
        "Copyright © 2022-23 by xyLOGIX, LLC.  All rights reserved.")]
[assembly:
    AssemblyTrademark(
        "This software is a component of xyLOGIX Project File Renamer.  xyLOGIX Project File Renamer is a trademark of xyLOGIX, LLC.  All rights reserved, especially those granted by international treaties.")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("efaea57a-ff8b-41f2-822d-21cec18d57b0")]

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
[assembly: AssemblyVersion("1.0.*")]
