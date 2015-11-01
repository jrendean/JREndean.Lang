

namespace JREndean.Lang.Continuations
{
    using JREndean.Lang.Chainings;

    public class WriteTextContinuation
    {
        private readonly string contents;

        public WriteTextContinuation(string contents)
        {
            this.contents = contents;
        }

        public WriteTo<string> To
        {
            get { return new WriteTo<string>(WriteTo<string>.Type.Text, this.contents); }
        }
    }
}
