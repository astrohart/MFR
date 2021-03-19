using System;
using System.IO;
using System.Text.RegularExpressions;

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
             * In this method, we make the following assumptions:
             *
             * (1) The 'source' parameter contains the full pathname of
             * an existing folder, and that said pathname is fully valid;
             * (2) The 'pattern' parameter contains the pattern to be
             * found in the name of the immediate child folder;
             * (3) The 'dest' parameter contains the text that should
             * be used instead of the matching text in 'source', and
             * (4) That all 3 of the parameters passed to this method
             * are blank.  Moreover,
             * (5) The only part of the folder path that should have the
             * replacement done on it is the name of the folder that is
             * lowest-level in the directory tree.
             */

            var result = string.Empty;

            // A directory pathname is passed in 'source.' Get the pathname to
            // the current folder's parent.
            var directoryInfo = new DirectoryInfo(source);
            var parentDirectoryInfo = directoryInfo.Parent;
            if (parentDirectoryInfo == null)
                return result; // no parent directory? stop.

            /*

            dirInfo.RenameTo(
                Path.Combine(
                    dirInfo.Parent.FullName,
                    dirInfo.Name.Replace(findWhat, replaceWith)
                )
            );

             */

            try
            {
                // gimme the new pathname of the folder after replacing the
                // specified text with the specified data in the lowest-level
                // folder name only. This is because this method is most likely
                // to be called from a recursive algorithm.

                if (!Configuration.MatchWholeWord)
                    result = Path.Combine(
                        parentDirectoryInfo
                            .FullName, // full pathname of parent folder
                        Configuration.MatchCase
                            ? directoryInfo.Name.Replace(pattern, dest)
                            : directoryInfo.Name.ReplaceNoCase(pattern, dest)
                    );
                else
                    result = Path.Combine(
                        parentDirectoryInfo.FullName,
                        Configuration.MatchCase
                            ? directoryInfo.Name.RegexReplaceWithCase(
                                $@"\b({Regex.Escape(pattern)})\b", dest
                            )
                            : directoryInfo.Name.RegexReplaceNoCase(
                                $@"\b({Regex.Escape(pattern)})\b", dest
                            )
                    );
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }
    }
}