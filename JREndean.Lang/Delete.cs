

namespace JREndean.Lang
{
    using JREndean.Lang.Continuations;
    using System;

    public static class Delete
    {
        public static FileContinuation File(Uri filePath)
        {
            // TODO: verifiy uri != null
            return File(filePath.LocalPath);
        }

        public static FileContinuation File(string filePath)
        {
            // TODO: verify !string.IsNullOrEmpty
            return new FileContinuation(filePath, false).Delete();
        }

        public static FolderContinuation Folder(Uri folderPath)
        {
            // TODO: verifiy uri != null
            return Folder(folderPath.LocalPath);
        }

        public static FolderContinuation Folder(string folderPath)
        {
            // TODO: verify !string.IsNullOrEmpty
            return new FolderContinuation(folderPath).Delete();
        }
    }
}
