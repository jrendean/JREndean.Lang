

namespace JREndean.Lang.Continuations
{
    using System;

    public class CreateNewContinuation
    {
        public FileContinuation File(Uri filePath)
        {
            // TODO: verifiy uri != null
            return File(filePath.LocalPath);
        }

        public FileContinuation File(string filePath)
        {
            // TODO: verify !string.IsNullOrEmpty
            return new FileContinuation(filePath, true);
        }

        public FolderContinuation Folder(Uri folderPath)
        {
            // TODO: verifiy uri != null
            return Folder(folderPath.LocalPath);
        }

        public FolderContinuation Folder(string folderPath)
        {
            // TODO: verify !string.IsNullOrEmpty
            return new FolderContinuation(folderPath).New();
        }
    }
}
