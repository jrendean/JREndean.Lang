

namespace JREndean.Lang.Continuations
{
    using System;
    using JREndean.Lang.Chainings;

    public class DoesContinuation<TValue, TOutput>
    {
        private readonly TValue value;
        private readonly bool truth;

        public DoesContinuation(TValue value, bool truth)
        {
            this.value = value;
            this.truth = truth;
        }

        public DoesContinuation<TValue, TOutput> Not
        {
            get { return new DoesContinuation<TValue, TOutput>(this.value, !this.truth); }
        }

        public IfThenElseResults<TValue, TOutput> Contain(TValue containsCheck)
        {
            try
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, this.CheckIfContains(containsCheck) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }

        private bool CheckIfContains(TValue containsCheck)
        {
            if (typeof(TValue) == typeof(string))
            {
                return this.value.ToString().Contains(containsCheck.ToString());
            }

            // TODO:
            //if (typeof(TValue) == typeof(IEnumerable))
            //{
            //    return from a in ((IEnumerable)this.value).AsQueryable() where a == containsCheck select a;
            //}


            // TODO: more
            return false;
        }
    }
}
