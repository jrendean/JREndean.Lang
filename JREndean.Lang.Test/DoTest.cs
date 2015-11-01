
namespace JREndean.Lang.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class DoTest
    {
        [TestMethod]
        public void DoAllTest()
        {
            int i = 0;

            Do.This(() => { i++; }).Times(5);
            Assert.AreEqual(5, i);

            // TODO:

            var t = Do.This(() => { }).While;//.True().Error(e => Assert.Fail());

            var f = Do.This(() => { }).While;//.False().Error(e => Assert.Fail());
        }
    }
}
