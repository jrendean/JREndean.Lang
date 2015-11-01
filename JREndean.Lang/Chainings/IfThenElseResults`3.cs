
namespace JREndean.Lang.Chainings
{
    using System;

    public class IfThenElseResults<TValue, TConvert, TOutput> 
        : ResultsError<TValue, TOutput>
        where TConvert : class
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

        public IfThenElseResults<TValue, TConvert, TOutput> Then(Func<TConvert, TOutput> thenAction)
        {
            if (!this.HasError && this.truth)
            {
                this.Results = thenAction(this.Value as TConvert);
            }

            return this;
        }

        public IfThenElseResults<TValue, TConvert, TOutput> Else(Func<TConvert, TOutput> elseAction)
        {
            if (!this.HasError && !this.truth)
            {
                this.Results = elseAction(this.Value as TConvert);
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
