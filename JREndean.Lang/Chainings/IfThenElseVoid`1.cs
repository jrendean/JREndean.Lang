

namespace JREndean.Lang.Chainings
{
    using System;

    public class IfThenElseVoid<TValue>
        : VoidError<TValue>
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

        public IfThenElseVoid<TValue> Then(Action<TValue> thenAction)
        {
            if (!this.HasError && this.truth)
            {
                thenAction(this.Value);
            }

            return this;
        }

        public IfThenElseVoid<TValue> Else(Action<TValue> elseAction)
        {
            if (!this.HasError && !this.truth)
            {
                elseAction(this.Value);
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
