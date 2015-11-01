
namespace JREndean.Lang.Continuations
{
    using System;
    using System.IO;
    using JREndean.Lang.Chainings;

    public class FileContinuation 
        : VoidError
    {
        private readonly string filePath;
        private bool isNew;
        private bool wasNew;

        public FileContinuation(string filePath, bool isNew)
        {
            this.filePath = filePath;
            this.isNew = isNew;
        }
        
        public FileContinuation Write(Func<string> writeFunc)
        {
            return this.Write(writeFunc());
        }

        public FileContinuation Write(string contents)
        {
            try
            {
                if (!this.HasError)
                {
                    // TODO: bug with Open.File.Read. then Write
                    using (StreamWriter sw = new StreamWriter(File.Open(this.filePath, this.isNew ? FileMode.Create : (this.wasNew ? FileMode.Append : FileMode.Open))))
                    {
                        sw.Write(contents);

                        // this allows to write again
                        if (this.isNew)
                        {
                            this.isNew = false;
                            this.wasNew = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }

            return this;
        }

        public FileContinuation Read(Action<string> readAction)
        {
            try
            {
                if (!this.HasError)
                {
                    using (StreamReader sr = new StreamReader(File.Open(this.filePath, this.isNew ? FileMode.OpenOrCreate : FileMode.Open)))
                    {
                        readAction(sr.ReadToEnd());
                    }
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }
            
            return this;
        }

        public FileContinuation Delete()
        {
            try
            {
                if (!this.HasError)
                {
                    File.Delete(this.filePath);
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
