
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using JREndean.Lang.Extensions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class NumberTest
    {
        [TestMethod]
        public void NumberAllTest()
        {
            // TODO:
            var numberIs = 6.Is();
            Assert.IsNotNull(numberIs);

            bool calledThen = false;
            bool calledElse = false;
            bool calledError = false;

            var gtThen1 = numberIs.GreaterThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gtThen1.HasError == false);
            Assert.IsTrue(gtThen1.Exception == null);
            calledElse = calledError = calledThen = false;


            var numberIsNot = 6.Is().Not;
            Assert.IsNotNull(numberIsNot);

            var gtThen2 = numberIsNot.GreaterThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gtThen2.HasError == false);
            Assert.IsTrue(gtThen2.Exception == null);
            calledElse = calledError = calledThen = false;
        }
    }
}
