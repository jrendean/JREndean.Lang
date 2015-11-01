
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class CreateTest
    {
        [TestMethod]
        public void CreateFolderTest()
        {
            var tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            Create.New.Folder(tempFolder).Error(e => Assert.Fail());
            Assert.IsTrue(Directory.Exists(tempFolder));
            Delete.Folder(tempFolder).Error(e => Assert.Fail());

            tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Create.New.Folder(tempFolder).Delete().Error(e => Assert.Fail());
            Assert.IsFalse(Directory.Exists(tempFolder));
        }

        [TestMethod]
        public void CreateFolderUriTest()
        {
            var tempFolder = new Uri(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));

            Create.New.Folder(tempFolder).Error(e => Assert.Fail());
            Assert.IsTrue(Directory.Exists(tempFolder.LocalPath));
            Delete.Folder(tempFolder).Error(e => Assert.Fail());
        }

        [TestMethod]
        public void CreateFileTest()
        {
            var tempFile = Path.GetTempFileName();

            Create.New.File(tempFile).Error(e => Assert.Fail());
            Assert.IsTrue(File.Exists(tempFile));
            Delete.File(tempFile).Error(e => Assert.Fail());

            tempFile = Path.GetTempFileName();
            Create.New.File(tempFile).Delete().Error(e => Assert.Fail());
            Assert.IsFalse(File.Exists(tempFile));

            tempFile = Path.GetTempFileName();
            Create.New.File(tempFile).Write("Hello World").Error(e => Assert.Fail());
            Assert.AreEqual("Hello World", File.ReadAllText(tempFile));
            Delete.File(tempFile).Error(e => Assert.Fail());

            tempFile = Path.GetTempFileName();
            Create.New.File(tempFile).Write("Hello World 1234").Read(s => Assert.AreEqual("Hello World 1234", s)).Error(e => Assert.Fail());
            Delete.File(tempFile).Error(e => Assert.Fail());
        }

        [TestMethod]
        public void CreateFileUriTest()
        {
            var tempFile = new Uri(Path.GetTempFileName());

            Create.New.File(tempFile).Error(e => Assert.Fail());
            Assert.IsTrue(File.Exists(tempFile.LocalPath));
            Delete.File(tempFile).Error(e => Assert.Fail());
        }
    }
}
