

namespace JREndean.Lang.Continuations
{
    using System;
    using JREndean.Lang.Chainings;

    public class DoThisContinuation
        : VoidError
    {
        private readonly Action theAction;

        public DoThisContinuation(Action theAction)
        {
            this.theAction = theAction;
        }

        public void Times(int count)
        {
            try
            {
                if (!this.HasError)
                {
                    for (int i = 0; i < count; i++)
                    {
                        this.theAction();
                    }
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }
        }

        public WhileContinuation While
        {
            get
            {
                return new WhileContinuation(this.theAction);
            }
        }
    }

}
