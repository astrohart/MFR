using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.VisualStudio.Instances.Interfaces;
using xyLOGIX.VisualStudio.Solutions.Factories;
using xyLOGIX.VisualStudio.Solutions.Interfaces;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Services.Solutions.Actions
{
    /// <summary>
    /// Exposes static methods, e.g., to get data sets from the system.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Services.Solutions.Actions.Get" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Get() { }

        /// <summary>
        /// Gets an enumerable collection of strings, each of which is the pathname of a
        /// Visual Studio Solution (*.sln) file in the root folder that has the specified
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder in which to search.
        /// </param>
        /// <returns>
        /// THe empty enumerable is returned if the specified
        /// <paramref name="pathname" /> is blank, or if an error occurs during the search
        /// operation; otherwise, an enumerable collection of
        /// <see cref="T:System.String" />s is returned, each element of which is the
        /// pathname of a <c>*.sln</c> file in the folder having the specified
        /// <paramref name="pathname" />.
        /// </returns>
        public static IEnumerable<string> SolutionPathsInFolder(string pathname)
        {
            var result = Enumerable.Empty<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Is.Folder(pathname)) return result;

                result = Directory.EnumerateFiles(
                                      pathname, "*.sln",
                                      SearchOption.AllDirectories
                                  )
                                  .Where(
                                      file => !Should.SkipSolutionFile(file)
                                  );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<string>();
            }

            return result;
        }

        /// <summary>
        /// Gets a reference to an instance of an object, implementing the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface, that represents a <c>Visual Studio Solution (*.sln)</c> file that is
        /// currently open in the specified <paramref name="instance" /> of Visual Studio,
        /// if any.
        /// </summary>
        /// <param name="instance">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.VisualStudio.Instances.Interfaces.IVisualStudioInstanceMetadata" />
        /// interface representing a currently-open instance of Visual Studio.
        /// </param>
        /// <remarks>
        /// This method also returns a <see langword="null" /> reference if the specified
        /// <paramref name="instance" />  of Visual Studio does not currently have a Visual
        /// Studio Solution (<c>*.sln</c>)  file open in it.
        /// </remarks>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface representing the <c>Visual Studio Solution (*.sln)</c> file that is
        /// currently open in the specified <paramref name="instance" />; otherwise, a
        /// <see langword="null" /> reference is returned.
        /// </returns>
        public static IVisualStudioSolution SolutionThatInstanceHasOpen(
            IVisualStudioInstanceMetadata instance
        )
        {
            IVisualStudioSolution result = default;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: Checking whether the 'instance' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, instance, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (instance == null)
                {
                    // The parameter, 'instance', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Get.SolutionThatInstanceHasOpen: *** ERROR *** A null reference was passed for the 'instance' method parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Get.SolutionThatInstanceHasOpen: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: *** SUCCESS *** We have been passed a valid object reference for the 'instance' method parameter.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: Checking whether the 'instance.Dte' property has a null reference for a value..."
                );

                // Check to see if the required property, instance.Dte, is null. If it is, send an
                // error to the log file and quit, returning the default value of the result
                // variable.
                if (instance.Dte == null)
                {
                    // The property, 'instance.Dte', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Get.SolutionThatInstanceHasOpen: *** ERROR *** The 'instance.Dte' property has a null reference.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Get.SolutionThatInstanceHasOpen: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: *** SUCCESS *** The 'instance.Dte' property has a valid object reference for its value.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: Attempting to get a handle to the Visual Studio Solution (*.sln) file that is currently open in the specified instance..."
                );

                result =
                    GetNewVisualStudioSolutionObject.ForVisualStudioInstance(
                        instance.Dte
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: Checking whether the operation to get a Visual Studio Solution (*.sln) file handle succeeded..."
                );

                // Check to see whether the operation to get a Visual Studio Solution (*.sln) file handle succeeded.
                // If this is not the case, then write an error message to the log file, and then terminate the execution
                // of this method.
                if (result == null)
                {
                    // The operation to get a Visual Studio Solution (*.sln) file handle did NOT succeed.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The operation to get a Visual Studio Solution (*.sln) file handle did NOT succeed.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Get.SolutionThatInstanceHasOpen: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: *** SUCCESS *** The operation to get a Visual Studio Solution (*.sln) file handle succeeded.  Proceeding..."
                );

                ProgramFlowHelper.StartDebugger();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: Checking whether the Process ID, or PID, of the instance is a valid value..."
                );

                // Check to see whether the Process ID, or PID, of the instance is a valid value.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (instance.PID <= 0)
                {
                    // The Process ID, or PID, of the instance is NOT set to a valid value.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Process ID, or PID, of the instance is NOT set to a valid value.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Get.SolutionThatInstanceHasOpen: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: *** SUCCESS *** The Process ID, or PID, of the instance is a valid value.  Proceeding..."
                );

                // Dump the value of the property, instance.SolutionPath, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Get.SolutionThatInstanceHasOpen: instance.SolutionPath = '{instance.SolutionPath}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the 'instance.SolutionPath' property has a null reference for a value, or is blank..."
                );

                // Check to see if the required property, instance.SolutionPath, is null or blank. If it is, send an 
                // error to the log file and quit, returning the default value of the result
                // variable.
                if (string.IsNullOrWhiteSpace(instance.SolutionPath))
                {
                    // the property instance.SolutionPath is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR: The 'instance.SolutionPath' property has a null reference or is blank.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR: This property is required to be set to a non-blank string before we can proceed."
                    );

                    // log the result
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Get.SolutionThatInstanceHasOpen: Result = {result}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "Get.SolutionThatInstanceHasOpen: Done."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The 'instance.SolutionPath' property is set to a non-blank string."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.SolutionThatInstanceHasOpen: Specifying the pathname of the Visual Studio Solution (*.sln) file open in the current instance, along with the Process ID (PID) of the current instance..."
                );

                result = result.SetPath(instance.SolutionPath)
                               .AndPID(instance.PID);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            DebugUtils.WriteLine(
                result != null ? DebugLevel.Info : DebugLevel.Error,
                result != null
                    ? "*** SUCCESS *** Obtained a handle to the currently-loaded Visual Studio Solution (*.sln) file that is loaded in the current instance of Visual Studio.  Proceeding..."
                    : "*** ERROR *** FAILED to obtain a handle to a currently-loaded Visual Studio Solution (*.sln) file that is loaded int he current instance of Visual Studio.  Stopping..."
            );

            return result;
        }
    }
}