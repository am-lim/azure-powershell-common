﻿namespace Microsoft.Azure.Commands.StorageSync.Evaluation.Interfaces
{
    public interface INamespaceEnumeratorListener
    {
        void NextFile(IFileInfo node);
        void BeginDir(IDirectoryInfo node);
        void EndDir(IDirectoryInfo node);
        void EndOfEnumeration(INamespaceInfo namespaceInfo);
        void UnauthorizedDir(IDirectoryInfo dir);
        void NamespaceHint(long directoryCount, long fileCount);
    }
}