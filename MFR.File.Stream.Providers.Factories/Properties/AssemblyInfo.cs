using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("xyLOGIX Factories Support Library for Project File Renamer's File Stream Providers Component")]
[assembly: AssemblyDescription("Provides objects and functionality to allocate a StreamReader for a file, given its path, and then return to the caller a GUID that is associated with the currently-allocated StreamReader.  This GUID can then be used as a 'ticket' of sorts, to request access to the corresponding StreamReader reference for use in processing the file.   We are creating this module since the currentl method of full-text search and replace for the Replace Text in Files operation is not scalable the way it is currently written, where the entire contents of text files are simply read into memory and then later searched.  This particular library holds the factories for this component.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("xyLOGIX, LLC")]
[assembly: AssemblyProduct("xyLOGIX Project File Renamer")]
[assembly:
    AssemblyCopyright(
        "Copyright © 2019-23 by xyLOGIX, LLC.  All rights reserved.")]
[assembly:
    AssemblyTrademark(
        "This software is a component of xyLOGIX Project File Renamer.  xyLOGIX Project File Renamer is a trademark of xyLOGIX, LLC.  All rights reserved, especially those granted by international treaties.")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a0ee1293-cdd0-4a03-8306-b6058264d5b5")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("2.0.0.0")]
