

namespace JREndean.Lang.Chainings
{
    using System;

    public class ResultsError<TValue, TOutput>
        : ResultsBase<TValue, TOutput>
    {
        public ResultsError(TValue value)
            : base(value)
        {
        }

        public ResultsError(TValue value, Exception exception)
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

        //public string Error()
        //{
        //    // TODO: get detailed information
        //    return this.Exception.Message;
        //}

        public ResultsError<TValue, TOutput> Error(Func<TValue, Exception, TOutput> errorAction)
        {
            if (this.HasError)
            {
                this.Results = errorAction(this.Value, this.Exception);
            }

            return this;
        }
    }
}

