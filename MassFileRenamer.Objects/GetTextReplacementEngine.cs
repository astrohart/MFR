using System;

namespace MassFileRenamer.Objects
{
    public static class GetTextReplacementEngine
    {
        public static ITextReplacementEngine For(OperationType type,
            IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            ITextReplacementEngine engine = null;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    engine = new FileNameReplacementEngine(configuration);
                    break;

                case OperationType.ReplaceTextInFiles:
                    engine = new TextInFileReplacementEngine(configuration);
                    break;

                case OperationType.RenameSubFolders:
                    engine = new FolderNameReplacementEngine(configuration);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"Creating a text-replacement engine for the operation type '{type}' is not supported."
                    );
            }

            return engine;
        }
    }
}