

namespace JREndean.Lang.Chainings
{
    using System;

    public class IfThenElseVoid<TValue, TConvert> 
        : VoidError<TValue>
        where TConvert : class
    {
        private readonly bool truth;

        public IfThenElseVoid(TValue value, bool truth)
            : base(value)
        {
            this.truth = truth;
        }

        public IfThenElseVoid(TValue value, Exception exception)
            : base(value, exception)
        {
        }

        public IfThenElseVoid<TValue, TConvert> Then(Action<TConvert> thenAction)
        {
            if (!this.HasError && this.truth)
            {
                thenAction(this.Value as TConvert);
            }

            return this;
        }

        public IfThenElseVoid<TValue, TConvert> Else(Action<TConvert> elseAction)
        {
            if (!this.HasError && !this.truth)
            {
                elseAction(this.Value as TConvert);
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
