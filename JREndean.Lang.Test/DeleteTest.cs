
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class DeleteTest
    {
        [TestMethod]
        public void DeleteFolderTest()
        {
            var tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            Create.New.Folder(tempFolder).Error(e => Assert.Fail());
            Assert.IsTrue(Directory.Exists(tempFolder));
            Delete.Folder(tempFolder).Error(e => Assert.Fail());

            tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Create.New.Folder(tempFolder).Delete().Error(e => Assert.Fail());
            Assert.IsFalse(Directory.Exists(tempFolder));

            // delete already deleted
            Delete.Folder(tempFolder).Error(e => Assert.IsInstanceOfType(e, typeof(DirectoryNotFoundException)));
        }

        [TestMethod]
        public void DeleteFileTest()
        {
            var tempFile = Path.GetTempFileName();

            Create.New.File(tempFile).Error(e => Assert.Fail());
            Assert.IsTrue(File.Exists(tempFile));
            Delete.File(tempFile).Error(e => Assert.Fail());

            tempFile = Path.GetTempFileName();
            Create.New.File(tempFile).Delete().Error(e => Assert.Fail());
            Assert.IsFalse(File.Exists(tempFile));

            // delete already deleted
            Delete.File(tempFile).Error(e => Assert.IsInstanceOfType(e, typeof(FileNotFoundException)));
        }
    }
}
