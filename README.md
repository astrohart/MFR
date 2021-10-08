# MFR (Mass File Renamer aka xyLOGIX Project File Renamer)

The xyLOGIX Project File Renamer, packaged as a WinForms app, is basically like a Find/Replace and Find in Files/Replace in Files tool, but for Solution Explorer.

![Fig01](fig01.png)

## Problem solved

For large software systems, components will be named according to a common naming convention.  Such as 

```
XYZ
XYZ.Forms
XYZ.Forms.Interfaces
XYZ.Forms.Presenters.Interfaces
XYZ.GUI.Windows
```

etc.

Let's suppose the `XYZ` project is the StartUp project and is a Console Application, and all the rest of the projects are class libraries.

What if, one day, you want to rename `XYZ` to `ABC` and, to be consistent, you want every project named accordingly (because they are all associated with each other)?

Of course, don't forget that we also have to update the `.sln` file and we also have to ensure that the (by convention) the names of the folders storying the `.csproj` files match the names of the projects, and that all internal code references are preserved.

Enter **Mass File Renamer** or, as it is brand-named, the **xyLOGIX Project File Renamer**.

**NOTE:** The tool assumes you architected the solution such that the `.sln` and `.csproj` are not in the same folder; rather, the `.sln` file is at least one folder level up from all `.csproj` files.

This tool allows you to start in a given folder (which must contain one or more `.sln` files, although those files can be at any level of recursion underneath) and you want to replace text in all the names of all the projects, and, say, you want to change the names of the corresponding folders, and, oh yea -- you still need the solution to build after all is said and done.

Simply configure this app as an **External Tool** in Visual Studio, and launch it.  Then, fill in the fields and away you go. 


In the **External Tools** configuration, you will have the option of specifying

```
--root="$(SolutionDir)"
```

in the **Arguments** field of its entry in the **External Tools** dialog box, as shown:

![Fig02](fig02.png)

This will cause the **What folder should the operation start in?** drop-down to be focused on the folder that the currently-open solution that is open in Visual Studio is located in.

![Fig03](fig03.png)

During its operation, before the app begins any of the requested operations, if it determines that one or more `.sln` files found in the folder tree beginning at the specified root are open in running instances of Visual Studio, it will:

1. Close the solution(s) in their respective instance(s) of Visual Studio;
2. Perform the requested operations; and
3. Re-open all previously closed solution(s), each in the instance of Visual Studio that it was originally open in.

**NOTE:** You can also run the tool in with the **What folder should the operation start in?** drop-down set to, in principle, _any_ folder on your hard disk, provided that that there are more than `.sln` files anywhere in the directory tree.
