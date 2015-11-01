

using JREndean.Lang.Chainings;
namespace JREndean.Lang.Continuations
{
    public class FindOrListContinuation
    {
        public enum Type
        {
            Files,

            Folders,

            // TODO: more?
        }

        private readonly Type type;

        public FindOrListContinuation(Type type)
        {
            this.type = type;
        }

        public FindOrListFrom From(string path)
        {
            return new FindOrListFrom(path);
        }
    }
}
