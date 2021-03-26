using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Contains rules to replace text in the pathnames of folders.
    /// </summary>
    public class FolderNameReplacementEngine : TextReplacementEngineBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FolderNameReplacementEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public FolderNameReplacementEngine()
        {
            // TODO: Add default object initialization here
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface that
        /// holds settings that are specified by the user.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="configuration" />, is passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public FolderNameReplacementEngine(IConfiguration configuration) : base(
            configuration
        ) { }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameSubFolders;

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression" />. Returns a string
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the data upon which the replacement
        /// operation is to be carried out.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that allows us to match
        /// the data to be replaced.
        /// </param>
        /// <param name="dest">
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the <paramref name="source" /> parameter does not contain
        /// the fully-qualified, absolute pathname to a folder.
        /// </exception>
        public override string Replace(string source, string pattern,
            string dest = "")
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            /*
             * Normally, the 'dest' parameter is optional for this method.
             * However, in the case of replacing text in the names of folders,
             * it's mandatory.  This is because, if 'dest' is blank or the
             * empty string, we run the risk of trying to create a folder that
             * has no name, which is in violation of OS rules.  Therefore,
             * we enforce that the dest parameter should have a value.
             */

            if (string.IsNullOrWhiteSpace(dest))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(dest)
                );

            /*
             * If the source parameter does not contain an absolute path,
             * then we cannot operate.
             */
            if (!source.IsAbsolutePath())
                throw new InvalidOperationException(
                    "You must pass an absolute (fully-qualified) pathname to a folder in the 'source' parameter."
                );

            /*
             * In this method, we make the following assumptions:
             *
             * (1) The 'source' parameter contains the full pathname of
             * an existing folder, and that said pathname is fully valid;
             * (2) The 'pattern' parameter contains the pattern to be
             * found in the name of the immediate child folder;
             * (3) The 'dest' parameter contains the text that should
             * be used instead of the matching text in 'source', and
             * (4) That all 3 of the parameters passed to this method
             * are never blank.  Moreover,
             * (5) The only part of the folder path that should have the
             * replacement done on it is the name of the folder that is
             * lowest-level in the directory tree.
             */

            var result =
                source; // no replacement is to occur if an exception is thrown

            try
            {
                var parentFolder = Path.GetDirectoryName(source);
                if (string.IsNullOrWhiteSpace(parentFolder)) return result;

                var folderName = Path.GetFileName(source);
                if (string.IsNullOrWhiteSpace(folderName)) return result;

                result = Path.Combine(
                    parentFolder,
                    /* only search and replace on the name of the lowest-
                     level folder in the pathname */
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         Configuration
                                             .GetTextMatchingConfiguration()
                                     )
                                     .Replace(folderName, pattern, dest)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = source;
            }

            return result;
        }
    }
}