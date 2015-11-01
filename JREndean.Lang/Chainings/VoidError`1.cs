

namespace JREndean.Lang.Chainings
{
    using System;

    public class VoidError<TValue>
        : VoidBase<TValue>
    {
        public VoidError(TValue value)
            : base(value)
        {
        }

        public VoidError(TValue value, Exception exception)
            : base(value)
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
            // TODO: get detailed information
            return this.Exception.Message;
        }

        public VoidError<TValue> Error(Action<TValue, Exception> errorAction)
        {
            if (this.HasError)
            {
                errorAction(this.Value, this.Exception);
            }

            return this;
        }
    }
}

