﻿using PostSharp.Patterns.Diagnostics;

namespace MassFileRenamer.Objects
{
    public class FolderTextValueRetriever : FileAndFolderTextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FolderTextValueRetriever()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FolderTextValueRetriever()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MassFileRenamer.Objects.FolderTextValueRetriever"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static FolderTextValueRetriever Instance
        {
            get;
        } = new FolderTextValueRetriever();

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MassFileRenamer.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        [Log(AttributeExclude = true)] public override OperationType OperationType
            => OperationType.RenameSubFolders;
    }
}