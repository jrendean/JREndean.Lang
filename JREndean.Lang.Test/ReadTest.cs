
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class ReadTest
    {
        [TestMethod]
        public void ReadTextFromFileTest()
        {
            var contents = Read.Text.From.File("");
        }

        [TestMethod]
        public void ReadTextFromScreenTest()
        {
            //var contents = Read.Text.From.Screen();
        }

        [TestMethod]
        public void ReadTextFromWebsiteTest()
        {
            var contents = Read.Text.From.Website("");
        }

        [TestMethod]
        public void ReadKeyFromScreenTest()
        {
            //var contents = Read.Key.From.Screen();
        }
    }
}
