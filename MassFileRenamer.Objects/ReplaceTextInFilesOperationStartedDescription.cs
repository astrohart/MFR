﻿using MassFileRenamer.Objects.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user at the start of a
    /// Replace Text In Files operation.
    /// </summary>
    public class
        ReplaceTextInFilesOperationStartedDescription : IOperationStartedDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ReplaceTextInFilesOperationStartedDescription()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ReplaceTextInFilesOperationStartedDescription()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MassFileRenamer.Objects.ReplaceTextInFilesOperationStartedDescription"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ReplaceTextInFilesOperationStartedDescription Instance
        {
            get;
        } = new ReplaceTextInFilesOperationStartedDescription();

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MassFileRenamer.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
        {
            get;
        } = OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Gets a string to be displayed to the user, that corresponds to the
        /// current type of operation that is being performed.
        /// </summary>
        /// <remarks>
        /// It is up to the implementers of this interface to supply the proper text.
        /// </remarks>
        public string Text
        {
            get;
        } = Resources.OperationStartedDescription_ReplaceTextInFiles;
    }
}