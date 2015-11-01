

namespace JREndean.Lang
{
    using JREndean.Lang.Continuations;
    using System;

    public static class Do
    {
        public static DoThisContinuation This(Action thisAction)
        {
            return new DoThisContinuation(thisAction);
        }
    }
}