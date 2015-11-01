
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class WriteTest
    {
        [TestMethod]
        public void WriteTextStringToFileTest()
        {
            Write.Text("text to write").To.File("");
        }

        [TestMethod]
        public void WriteTextStringToScreenTest()
        {
            Write.Text("text to write").To.Screen();
        }

        [TestMethod]
        public void WriteTextStringToWebsiteTest()
        {
            Write.Text("text to write").To.Website("");
        }

        [TestMethod]
        public void WriteTextFuncToFileTest()
        {
            Write.Text(() => { return "text to write"; }).To.File("");
        }

        [TestMethod]
        public void WriteTextFuncToScreenTest()
        {
            Write.Text(() => { return "text to write"; }).To.Screen();
        }

        [TestMethod]
        public void WriteTextFuncToWebsiteTest()
        {
            Write.Text(() => { return "text to write"; }).To.Website("");
        }
    }
}
