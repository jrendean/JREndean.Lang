

namespace JREndean.Lang.Chainings
{
    using System;

    public class VoidError
        : VoidBase
    {
        public VoidError()
        {
        }

        public VoidError(Exception exception)
        {
            this.Exception = exception;
        }

        public Exception Exception
        {
            get;
            protected set;
        }

        public bool HasError
        {
            get
            { 
                return this.Exception != null;
            }
        }

        public string Error()
        {
            return null;
        }

        public VoidError Error(Action<Exception> errorAction)
        {
            if (this.HasError)
            {
                errorAction(this.Exception);
            }

            return this;
        }
    }
}

