using MFR.Objects.Expressions.Matches.Factories.Interfaces;
using MFR.Objects.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using Alphaleonis.Win32.Filesystem;
using xyLOGIX.Core.Debug;

namespace MFR.Objects.Expressions.Matches.Factories
{
    public class FileNameReplacementMatchExpressionFactory : FileAndFolderMatchExpressionFactoryBase
    {
        /// <summary>
        /// Gets one of the <see
        /// cref="T:MFR.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.RenameFilesInFolder;

        /// <summary>
        /// Sets the text data to be searched for a pattern.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data to be searched for a pattern.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value"/>, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <remarks>
        /// Among the fluent-builder methods of this class, this one must be
        /// invoked first.
        /// <para/>
        /// However, prior to even invoking this method, the <see
        /// cref="M:MFR.Objects.IConfigurationComposedObject.AndAttachConfiguration"/>
        /// method must be invoked; otherwise, a <see
        /// cref="T:MFR.Objects.ConfigurationNotAttachedException"/>
        /// will be thrown. It is incumbent upon invokers of this method to
        /// first weed out any possible elements of the source value set that
        /// may make the <paramref name="value"/> parameter get passed a blank string.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value"/>, is
        /// passed either the empty or <see langword="null" /> string for a value.
        /// Whitespace is allowed ONLY for the Replace Text in Files operation type.
        /// </exception>
        public override IMatchExpressionFactory ForTextValue(string value)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In FileNameReplacementMatchExpressionFactory.ForTextValue");

            return base.ForTextValue(
                Path.GetFileName(value)
            );
        }
    }
}