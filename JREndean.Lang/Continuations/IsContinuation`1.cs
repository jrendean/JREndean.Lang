
namespace JREndean.Lang.Continuations
{
    using System;
    using System.Collections;
    using JREndean.Lang.Chainings;

    public class IsContinuation<TValue>
    {
        private readonly TValue value;
        private readonly bool truth;

        public IsContinuation(TValue value, bool truth)
        {
            this.value = value;
            this.truth = truth;
        }

        public IsContinuation<TValue> Not
        {
            get { return new IsContinuation<TValue>(this.value, !this.truth); }
        }

        public IfThenElseVoid<TValue> Null()
        {
            try
            {
                return new IfThenElseVoid<TValue>(this.value, (this.value == null) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue>(this.value, ex);
            }
        }

        //public IfThenElseVoid<TValue> NotNull()
        //{
        //    try
        //    {
        //        return new IfThenElseVoid<TValue>(this.value, (this.value != null) == this.truth);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new IfThenElseVoid<TValue>(this.value, ex);
        //    }
        //}

        public IfThenElseVoid<TValue> Empty()
        {
            try
            {
                if (this.value is string)
                {
                    return new IfThenElseVoid<TValue>(this.value, (this.value.ToString() == string.Empty) == this.truth);
                }
                else if (this.value is ICollection)
                {
                    return new IfThenElseVoid<TValue>(this.value, (((ICollection)this.value).Count == 0) == this.truth);
                }

                // TODO: others?
                throw new NotSupportedException("Cannot check if this type is empty");
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue>(this.value, ex);
            }
        }

        ////public IfThenElseVoid<TValue> NotEmpty()
        ////{
        ////    try
        ////    {
        ////        if (this.value is string)
        ////        {
        ////            return new IfThenElseVoid<TValue>(this.value, (this.value.ToString() != string.Empty) == this.truth);
        ////        }
        ////        else if (this.value is ICollection)
        ////        {
        ////            return new IfThenElseVoid<TValue>(this.value, (((ICollection)this.value).Count > 0) == this.truth);
        ////        }

        ////        // TODO: others?
        ////        throw new NotSupportedException("Cannot check if this type is empty");
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        return new IfThenElseVoid<TValue>(this.value, ex);
        ////    }
        ////}

        public IfThenElseVoid<TValue, TOf> TypeOf<TOf>() where TOf : class
        {
            try
            {
                if (this.value == null)
                {
                    throw new NullReferenceException("The values type cannot be determined since its value is null.");
                }

                return new IfThenElseVoid<TValue, TOf>(this.value, (typeof(TValue) == typeof(TOf)) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue, TOf>(this.value, ex);
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

        public IfThenElseVoid<TValue> GreaterThan<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseVoid<TValue>(this.value, (compare.CompareTo(this.value) < 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue>(this.value, ex);
            }
        }

        public IfThenElseVoid<TValue> GreaterThanOrEqual<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseVoid<TValue>(this.value, (compare.CompareTo(this.value) <= 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue>(this.value, ex);
            }
        }

        public IfThenElseVoid<TValue> LessThan<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseVoid<TValue>(this.value, (compare.CompareTo(this.value) > 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue>(this.value, ex);
            }
        }

        public IfThenElseVoid<TValue> LessThanOrEqual<TComparer>(TComparer compare) where TComparer : IComparable
        {
            try
            {
                return new IfThenElseVoid<TValue>(this.value, (compare.CompareTo(this.value) >= 0) == this.truth);
            }
            catch (Exception ex)
            {
                return new IfThenElseVoid<TValue>(this.value, ex);
            }
        }
    }
}
