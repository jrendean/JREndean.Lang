
namespace JREndean.Lang.Continuations
{
    using System;
    using System.Collections;
    using JREndean.Lang.Chainings;

    public class IsContinuation<TValue, TOutput>
    {
        private readonly TValue value;
        private readonly bool truth;

        public IsContinuation(TValue value, bool truth)
        {
            this.value = value;
            this.truth = truth;
        }

        public IsContinuation<TValue, TOutput> Not
        {
            get { return new IsContinuation<TValue, TOutput>(this.value, !this.truth); }
        }

        public IfThenElseResults<TValue, TOutput> Null()
        {
            try
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, (this.value == null) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }

        //public IfThenElseResults<TValue, TOutput> NotNull()
        //{
        //    try
        //    {
        //        return new IfThenElseResults<TValue, TOutput>(this.value, (this.value != null) == this.truth);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new IfThenElseResults<TValue, TOutput>(this.value, ex);
        //    }
        //}

        public IfThenElseResults<TValue, TOutput> Empty()
        {
            try
            {
                if (this.value is string)
                {
                    return new IfThenElseResults<TValue, TOutput>(this.value, (this.value.ToString() == string.Empty) == this.truth);
                }
                else if (this.value is ICollection)
                {
                    return new IfThenElseResults<TValue, TOutput>(this.value, (((ICollection)this.value).Count == 0) == this.truth);
                }

                // TODO: others?
                throw new NotSupportedException("Cannot check if this type is empty");
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }

        //public IfThenElseResults<TValue, TOutput> NotEmpty()
        //{
        //    try
        //    {
        //        if (this.value is string)
        //        {
        //            return new IfThenElseResults<TValue, TOutput>(this.value, (this.value.ToString() != string.Empty) == this.truth);
        //        }
        //        else if (this.value is ICollection)
        //        {
        //            return new IfThenElseResults<TValue, TOutput>(this.value, (((ICollection)this.value).Count > 0) == this.truth);
        //        }

        //        // TODO: others?
        //        throw new NotSupportedException("Cannot check if this type is empty");
        //    }
        //    catch (Exception ex)
        //    {
        //        return new IfThenElseResults<TValue, TOutput>(this.value, ex);
        //    }
        //}

        public IfThenElseResults<TValue, TOf, TOutput> TypeOf<TOf>() where TOf : class
        {
            try
            {
                if (this.value == null)
                {
                    throw new NullReferenceException("The values type cannot be determined since its value is null.");
                }

                return new IfThenElseResults<TValue, TOf, TOutput>(this.value, (typeof(TValue) == typeof(TOf)) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOf, TOutput>(this.value, ex);
            }
        }

        //public Continuation<TValue, TFrom> InheritableFrom<TFrom>() where TFrom : class
        //{
        //    try
        //    {
        //        if (this.value == null)
        //        {
        //            throw new NullReferenceException("The values type cannot be determined since its value is null.");
        //        }

        //        return new Continuation<TValue, TFrom>(this.value, (this.value is TFrom) == this.truth);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Continuation<TValue, TFrom>(this.value, ex);
        //    }
        //}

        public IfThenElseResults<TValue, TOutput> GreaterThan<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, (compare.CompareTo(this.value) < 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }

        public IfThenElseResults<TValue, TOutput> GreaterThanOrEqual<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, (compare.CompareTo(this.value) <= 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }

        public IfThenElseResults<TValue, TOutput> LessThan<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, (compare.CompareTo(this.value) > 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }

        public IfThenElseResults<TValue, TOutput> LessThanOrEqual<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, (compare.CompareTo(this.value) >= 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseResults<TValue, TOutput>(this.value, ex);
            }
        }
    }
}
