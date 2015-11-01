
namespace JREndean.Lang.Chainings
{
    using System;

    public class IfThenElseResults<TValue, TOutput>
        : ResultsError<TValue, TOutput>
    {
        private readonly bool truth;
       
        public IfThenElseResults(TValue value, bool truth)
            : base(value)
        {
            this.truth = truth;
        }

        public IfThenElseResults(TValue value, Exception exception)
            : base(value, exception)
        {
        }

        public IfThenElseResults<TValue, TOutput> Then(Func<TValue, TOutput> thenAction)
        {
            if (!this.HasError && this.truth)
            {
                this.Results = thenAction(this.Value);
            }

            return this;
        }

        public IfThenElseResults<TValue, TOutput> Else(Func<TValue, TOutput> elseAction)
        {
            if (!this.HasError && !this.truth)
            {
                this.Results = elseAction(this.Value);
            }

            return this;
        }

        public void Throw<TException>() where TException : Exception
        {
            if (!this.HasError && this.truth)
            {
                throw default(TException);
            }
        }

        public void Throw(Exception exception)
        {
            if (!this.HasError && this.truth)
            {
                // TODO: check null
                throw exception;
            }
        }
    }
}
