
namespace JREndean.Lang.Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class ListTest
    {
        [TestMethod]
        public void ListFilesTest()
        {
            var f = List.Files.From("").Results;
        }

        [TestMethod]
        public void ListFilesMatchingTest()
        {
            var f = List.Files.From("").Matching("").Results;
        }

        [TestMethod]
        public void ListFoldersTest()
        {
            var f = List.Folders.From("").Results;
        }

        [TestMethod]
        public void ListFoldersMatchingTest()
        {
            var f = List.Folders.From("").Matching("").Results;
        }
    }
}
