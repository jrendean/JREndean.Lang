
namespace JREndean.Lang.Continuations
{
    using System;
    using System.Net;
    using JREndean.Lang.Chainings;

    public class WebContinuation 
        : VoidError
    {
        private readonly string url;

        public WebContinuation(string url)
        {
            this.url = url;
        }
        
        public WebContinuation Write(Func<string> writeFunc)
        {
            return this.Write(writeFunc());
        }

        public WebContinuation Write(string contents)
        {
            try
            {
                if (!this.HasError)
                {
                    // TODO: implement
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }

            return this;
        }

        public WebContinuation Read(Action<string> readAction)
        {
            try
            {
                if (!this.HasError)
                {
                    // TODO: implement
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
