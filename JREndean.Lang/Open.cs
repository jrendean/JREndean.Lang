

namespace JREndean.Lang
{
    using System;

    using JREndean.Lang.Continuations;

    public static class Open
    {
        public static FileContinuation File(Uri filePath)
        {
            // TODO: verifiy uri != null
            If.Value(filePath).Is.Null().Throw<ArgumentNullException>();

            return File(filePath.AbsolutePath);
        }

        public static FileContinuation File(string filePath)
        {
            // TODO: verify !string.IsNullOrEmpty
            return new FileContinuation(filePath, false);
        }

        public static WebContinuation Website(Uri url)
        {
            // TODO: verifiy uri != null
            return Website(url.AbsolutePath);
        }

        public static WebContinuation Website(string url)
        {
            // TODO: verify !string.IsNullOrEmpty
            return new WebContinuation(url);
        }
    }
}
