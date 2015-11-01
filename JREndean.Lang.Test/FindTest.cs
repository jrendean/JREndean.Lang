
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class FindTest
    {
        [TestMethod]
        public void FindFilesTest()
        {
            var f = Find.Files.From("").Results;
        }

        [TestMethod]
        public void FindFilesMatchingTest()
        {
            var f = Find.Files.From("").Matching("").Results;
        }

        [TestMethod]
        public void FindFoldersTest()
        {
            var f = Find.Folders.From("").Results;
        }

        [TestMethod]
        public void FindFoldersMatchingTest()
        {
            var f = Find.Folders.From("").Matching("").Results;
        }
    }
}
