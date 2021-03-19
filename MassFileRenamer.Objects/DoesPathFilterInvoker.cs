namespace MassFileRenamer.Objects
{
    public static class DoesPathFilterInvoker
    {
        public static IPathFilterInvoker For(IFileSystemEntry entry)
            => PathFilterInvokerBase.Instance.AndPath(entry?.Path);

        public static IPathFilterInvoker FromScratch()
                    => PathFilterInvokerBase.Instance;
    }
}