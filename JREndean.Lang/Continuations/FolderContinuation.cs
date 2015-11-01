
namespace JREndean.Lang.Continuations
{
    using System;
    using System.IO;
    using JREndean.Lang.Chainings;

    public class FolderContinuation
        : VoidError
    {
        private readonly string folderPath;

        public FolderContinuation(string folderPath)
        {
            this.folderPath = folderPath;
        }

        public FolderContinuation New()
        {
            try
            {
                if (!this.HasError)
                {
                    Directory.CreateDirectory(this.folderPath);
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }

            return this;
        }

        public FolderContinuation Delete()
        {
            try
            {
                if (!this.HasError)
                {
                    Directory.Delete(this.folderPath);
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }

            return this;
        }
    }
}
