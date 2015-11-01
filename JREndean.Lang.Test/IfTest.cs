

namespace JREndean.Lang.Test
{
    using System.Runtime;

    using JREndean.Lang.Continuations;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class IfTest
    {
        [TestMethod]
        public void IfVoidTestAll()
        {
            var ifStringValue = If.Value("foo");
            Assert.IsNotNull(ifStringValue.Is);
            //Assert.IsNotNull(ifStringValue.IsNot);
            Assert.IsNotNull(ifStringValue.Does);
            //Assert.IsNotNull(ifStringValue.DoesNot);

            bool calledThen = false;
            bool calledElse = false;
            bool calledError = false;

            // 
            // Is/IsNot
            // 
            // Empty/NotEmpty
            var isEmpty = ifStringValue.Is.Empty().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(isEmpty.HasError == false);
            Assert.IsTrue(isEmpty.Exception == null);
            calledElse = calledError = calledThen = false;

            //var isNotEmpty1 = ifStringValue.Is.NotEmpty().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            //Assert.IsTrue(calledThen == true);
            //Assert.IsTrue(calledElse == false);
            //Assert.IsTrue(calledError == false);
            //Assert.IsTrue(isNotEmpty1.HasError == false);
            //Assert.IsTrue(isNotEmpty1.Exception == null);
            //calledElse = calledError = calledThen = false;

            var isNotEmpty2 = ifStringValue.Is.Not.Empty().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(isNotEmpty2.HasError == false);
            Assert.IsTrue(isNotEmpty2.Exception == null);
            calledElse = calledError = calledThen = false;

            // Null/NotNull
            var isNull = ifStringValue.Is.Null().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(isNull.HasError == false);
            Assert.IsTrue(isNull.Exception == null);
            calledElse = calledError = calledThen = false;

            //var isNotNull1 = ifStringValue.Is.NotNull().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            //Assert.IsTrue(calledThen == true);
            //Assert.IsTrue(calledElse == false);
            //Assert.IsTrue(calledError == false);
            //Assert.IsTrue(isNotNull1.HasError == false);
            //Assert.IsTrue(isNotNull1.Exception == null);
            //calledElse = calledError = calledThen = false;

            var isNotNull2 = ifStringValue.Is.Not.Null().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(isNotNull2.HasError == false);
            Assert.IsTrue(isNotNull2.Exception == null);
            calledElse = calledError = calledThen = false;

            // TypeOf
            var typeofGood1 = ifStringValue.Is.TypeOf<string>().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(typeofGood1.HasError == false);
            Assert.IsTrue(typeofGood1.Exception == null);
            calledElse = calledError = calledThen = false;

            var typeofGood2 = ifStringValue.Is.Not.TypeOf<string>().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(typeofGood2.HasError == false);
            Assert.IsTrue(typeofGood2.Exception == null);
            calledElse = calledError = calledThen = false;

            var typeofBad = ifStringValue.Is.TypeOf<System.TimeZone>().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(typeofBad.HasError == false);
            Assert.IsTrue(typeofBad.Exception == null);
            calledElse = calledError = calledThen = false;

            // GreaterThan
            var gtThen1 = If.Value(6).Is.GreaterThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gtThen1.HasError == false);
            Assert.IsTrue(gtThen1.Exception == null);
            calledElse = calledError = calledThen = false;

            var gtElse1 = If.Value(5).Is.GreaterThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gtElse1.HasError == false);
            Assert.IsTrue(gtElse1.Exception == null);
            calledElse = calledError = calledThen = false;
            
            var gtElse2 = If.Value(6).Is.Not.GreaterThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gtElse2.HasError == false);
            Assert.IsTrue(gtElse2.Exception == null);
            calledElse = calledError = calledThen = false;

            var gtError = ifStringValue.Is.GreaterThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == true);
            Assert.IsTrue(gtError.HasError == true);
            Assert.IsTrue(gtError.Exception != null);
            calledElse = calledError = calledThen = false;

            // GreaterThanOrEqual
            var gteThen1 = If.Value(6).Is.GreaterThanOrEqual(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gteThen1.HasError == false);
            Assert.IsTrue(gteThen1.Exception == null);
            calledElse = calledError = calledThen = false;

            var gteThen2 = If.Value(5).Is.GreaterThanOrEqual(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gteThen2.HasError == false);
            Assert.IsTrue(gteThen2.Exception == null);
            calledElse = calledError = calledThen = false;

            var gteElse1 = If.Value(6).Is.Not.GreaterThanOrEqual(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(gteElse1.HasError == false);
            Assert.IsTrue(gteElse1.Exception == null);
            calledElse = calledError = calledThen = false;

            var gteError = ifStringValue.Is.GreaterThanOrEqual(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == true);
            Assert.IsTrue(gteError.HasError == true);
            Assert.IsTrue(gteError.Exception != null);
            calledElse = calledError = calledThen = false;

            // LessThan
            var ltThen1 = If.Value(5).Is.LessThan(6).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(ltThen1.HasError == false);
            Assert.IsTrue(ltThen1.Exception == null);
            calledElse = calledError = calledThen = false;

            var ltElse1 = If.Value(5).Is.LessThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(ltElse1.HasError == false);
            Assert.IsTrue(ltElse1.Exception == null);
            calledElse = calledError = calledThen = false;

            var ltElse2 = If.Value(5).Is.Not.LessThan(6).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(ltElse2.HasError == false);
            Assert.IsTrue(ltElse2.Exception == null);
            calledElse = calledError = calledThen = false;

            var ltError = ifStringValue.Is.LessThan(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == true);
            Assert.IsTrue(ltError.HasError == true);
            Assert.IsTrue(ltError.Exception != null);
            calledElse = calledError = calledThen = false;

            // LessThanOrEqual
            var lteThen1 = If.Value(5).Is.LessThanOrEqual(6).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(lteThen1.HasError == false);
            Assert.IsTrue(lteThen1.Exception == null);
            calledElse = calledError = calledThen = false;

            var lteThen2 = If.Value(5).Is.LessThanOrEqual(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(lteThen2.HasError == false);
            Assert.IsTrue(lteThen2.Exception == null);
            calledElse = calledError = calledThen = false;

            var lteElse1 = If.Value(5).Is.Not.LessThanOrEqual(6).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(lteElse1.HasError == false);
            Assert.IsTrue(lteElse1.Exception == null);
            calledElse = calledError = calledThen = false;
            
            var lteError = ifStringValue.Is.LessThanOrEqual(5).Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == true);
            Assert.IsTrue(lteError.HasError == true);
            Assert.IsTrue(lteError.Exception != null);
            calledElse = calledError = calledThen = false;

            // 
            // Does/DoesNot
            // 
            // Contain
            var doesContain = ifStringValue.Does.Contain("fo").Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(doesContain.HasError == false);
            Assert.IsTrue(doesContain.Exception == null);
            calledElse = calledError = calledThen = false;

            var doesNotContain1 = ifStringValue.Does.Not.Contain("fo").Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == true);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(doesNotContain1.HasError == false);
            Assert.IsTrue(doesNotContain1.Exception == null);
            calledElse = calledError = calledThen = false;

            var doesNotContain2 = ifStringValue.Does.Not.Contain("bar").Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == true);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == false);
            Assert.IsTrue(doesNotContain2.HasError == false);
            Assert.IsTrue(doesNotContain2.Exception == null);
            calledElse = calledError = calledThen = false;

            // Does/DoesNot Contain on IEnumberable
            //var stringArray = new string[] { "Foo", "Bar" };
            //var doesContainIEnumThen = If.Value(stringArray).Does.Contain("Foo").Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            //Assert.IsTrue(calledThen == true);
            //Assert.IsTrue(calledElse == false);
            //Assert.IsTrue(calledError == false);
            //Assert.IsTrue(doesContainIEnumThen.HasError == false);
            //Assert.IsTrue(doesContainIEnumThen.Exception == null);
            //calledElse = calledError = calledThen = false;

            //var doesContainIEnumElse = If.Value(stringArray).Does.Contain("fo").Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            //Assert.IsTrue(calledThen == false);
            //Assert.IsTrue(calledElse == true);
            //Assert.IsTrue(calledError == false);
            //Assert.IsTrue(doesContainIEnumElse.HasError == false);
            //Assert.IsTrue(doesContainIEnumElse.Exception == null);
            //calledElse = calledError = calledThen = false;


            // 
            // Throws
            // 
            try
            {
                If.Value("asdf").Is.Not.Null().Throw(new NullReferenceException());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            try
            {
                If.Value("asdf").Is.Not.Null().Throw<NullReferenceException>();
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            // Errors
            var isEmptyError = If.Value(5).Is.Empty().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            Assert.IsTrue(calledThen == false);
            Assert.IsTrue(calledElse == false);
            Assert.IsTrue(calledError == true);
            Assert.IsTrue(isEmptyError.HasError == true);
            Assert.IsTrue(isEmptyError.Exception != null);
            calledElse = calledError = calledThen = false;

            //var isNotEmptyError = If.Value(5).Is.NotEmpty().Then(a => calledThen = true).Else(a => calledElse = true).Error((a, e) => calledError = true);
            //Assert.IsTrue(calledThen == false);
            //Assert.IsTrue(calledElse == false);
            //Assert.IsTrue(calledError == true);
            //Assert.IsTrue(isNotEmptyError.HasError == true);
            //Assert.IsTrue(isNotEmptyError.Exception != null);
            //calledElse = calledError = calledThen = false;
        }

        [TestMethod]
        public void IfResultsTestAll()
        {
            var ifStringValue = If.Value<string, int>("foo");
            Assert.IsNotNull(ifStringValue.Is);
            //Assert.IsNotNull(ifStringValue.IsNot);
            Assert.IsNotNull(ifStringValue.Does);
            //Assert.IsNotNull(ifStringValue.DoesNot);

            //
            // Is/IsNot
            // 
            // Empty/NotEmpty
            var isEmpty = ifStringValue.Is.Empty().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(isEmpty.Results == 2);
            Assert.IsTrue(isEmpty.HasError == false);
            Assert.IsTrue(isEmpty.Exception == null);

            //var isNotEmpty1 = ifStringValue.Is.NotEmpty().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            //Assert.IsTrue(isNotEmpty1.Results == 1);
            //Assert.IsTrue(isNotEmpty1.HasError == false);
            //Assert.IsTrue(isNotEmpty1.Exception == null);

            var isNotEmpty2 = ifStringValue.Is.Not.Empty().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(isNotEmpty2.Results == 1);
            Assert.IsTrue(isNotEmpty2.HasError == false);
            Assert.IsTrue(isNotEmpty2.Exception == null);

            // Null/NotNull
            var isNull = ifStringValue.Is.Null().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(isNull.Results == 2);
            Assert.IsTrue(isNull.HasError == false);
            Assert.IsTrue(isNull.Exception == null);

            //var isNotNull1 = ifStringValue.Is.NotNull().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            //Assert.IsTrue(isNotNull1.Results == 1);
            //Assert.IsTrue(isNotNull1.HasError == false);
            //Assert.IsTrue(isNotNull1.Exception == null);

            var isNotNull2 = ifStringValue.Is.Not.Null().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(isNotNull2.Results == 1);
            Assert.IsTrue(isNotNull2.HasError == false);
            Assert.IsTrue(isNotNull2.Exception == null);

            // TypeOf
            var typeofGood1 = ifStringValue.Is.TypeOf<string>().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(typeofGood1.Results == 1);
            Assert.IsTrue(typeofGood1.HasError == false);
            Assert.IsTrue(typeofGood1.Exception == null);

            var typeofGood2 = ifStringValue.Is.Not.TypeOf<string>().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(typeofGood2.Results == 2);
            Assert.IsTrue(typeofGood2.HasError == false);
            Assert.IsTrue(typeofGood2.Exception == null);

            var typeofBad = ifStringValue.Is.TypeOf<System.TimeZone>().Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(typeofBad.Results == 2);
            Assert.IsTrue(typeofBad.HasError == false);
            Assert.IsTrue(typeofBad.Exception == null);

            // GreaterThan
            var gtThen1 = If.Value<int, int>(6).Is.GreaterThan(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gtThen1.Results == 1);
            Assert.IsTrue(gtThen1.HasError == false);
            Assert.IsTrue(gtThen1.Exception == null);

            var gtElse1 = If.Value<int, int>(5).Is.GreaterThan(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gtElse1.Results == 2);
            Assert.IsTrue(gtElse1.HasError == false);
            Assert.IsTrue(gtElse1.Exception == null);

            var gtElse2 = If.Value<int, int>(6).Is.Not.GreaterThan(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gtElse2.Results == 2);
            Assert.IsTrue(gtElse2.HasError == false);
            Assert.IsTrue(gtElse2.Exception == null);

            var gtError = ifStringValue.Is.GreaterThan(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gtError.Results == 3);
            Assert.IsTrue(gtError.HasError == true);
            Assert.IsTrue(gtError.Exception != null);

            // GreaterThanOrEqual
            var gteThen1 = If.Value<int, int>(6).Is.GreaterThanOrEqual(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gteThen1.Results == 1);
            Assert.IsTrue(gteThen1.HasError == false);
            Assert.IsTrue(gteThen1.Exception == null);

            var gteThen2 = If.Value<int, int>(5).Is.GreaterThanOrEqual(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gteThen2.Results == 1);
            Assert.IsTrue(gteThen2.HasError == false);
            Assert.IsTrue(gteThen2.Exception == null);

            var gteElse1 = If.Value<int, int>(6).Is.Not.GreaterThanOrEqual(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gteElse1.Results == 2);
            Assert.IsTrue(gteElse1.HasError == false);
            Assert.IsTrue(gteElse1.Exception == null);

            var gteError = ifStringValue.Is.GreaterThanOrEqual(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(gteError.Results == 3);
            Assert.IsTrue(gteError.HasError == true);
            Assert.IsTrue(gteError.Exception != null);

            // LessThan
            var ltThen1 = If.Value<int, int>(5).Is.LessThan(6).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(ltThen1.Results == 1);
            Assert.IsTrue(ltThen1.HasError == false);
            Assert.IsTrue(ltThen1.Exception == null);

            var ltElse1 = If.Value<int, int>(5).Is.LessThan(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(ltElse1.Results == 2);
            Assert.IsTrue(ltElse1.HasError == false);
            Assert.IsTrue(ltElse1.Exception == null);

            var ltElse2 = If.Value<int, int>(5).Is.Not.LessThan(6).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(ltElse2.Results == 2);
            Assert.IsTrue(ltElse2.HasError == false);
            Assert.IsTrue(ltElse2.Exception == null);

            var ltError = ifStringValue.Is.LessThan(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(ltError.Results == 3);
            Assert.IsTrue(ltError.HasError == true);
            Assert.IsTrue(ltError.Exception != null);

            // LessThanOrEqual
            var lteThen1 = If.Value<int, int>(5).Is.LessThanOrEqual(6).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(lteThen1.Results == 1);
            Assert.IsTrue(lteThen1.HasError == false);
            Assert.IsTrue(lteThen1.Exception == null);

            var lteThen2 = If.Value<int, int>(5).Is.LessThanOrEqual(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(lteThen2.Results == 1);
            Assert.IsTrue(lteThen2.HasError == false);
            Assert.IsTrue(lteThen2.Exception == null);

            var lteElse1 = If.Value<int, int>(5).Is.Not.LessThanOrEqual(6).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(lteElse1.Results == 2);
            Assert.IsTrue(lteElse1.HasError == false);
            Assert.IsTrue(lteElse1.Exception == null);

            var lteError = ifStringValue.Is.LessThanOrEqual(5).Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(lteError.Results == 3);
            Assert.IsTrue(lteError.HasError == true);
            Assert.IsTrue(lteError.Exception != null);

            // 
            // Does/DoesNot
            // 
            // Contain
            var doesContain = ifStringValue.Does.Contain("fo").Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(doesContain.Results == 1);
            Assert.IsTrue(doesContain.HasError == false);
            Assert.IsTrue(doesContain.Exception == null);

            var doesNotContain1 = ifStringValue.Does.Not.Contain("fo").Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(doesNotContain1.Results == 2);
            Assert.IsTrue(doesNotContain1.HasError == false);
            Assert.IsTrue(doesNotContain1.Exception == null);

            var doesNotContain2 = ifStringValue.Does.Not.Contain("bar").Then(a => 1).Else(a => 2).Error((a, e) => 3);
            Assert.IsTrue(doesNotContain2.Results == 1);
            Assert.IsTrue(doesNotContain2.HasError == false);
            Assert.IsTrue(doesNotContain2.Exception == null);

            // Does/DoesNot Contain on IEnumberable
            //var stringArray = new string[] { "Foo", "Bar" };
            //var doesContainIEnumThen = If.Value(stringArray).Does.Contain("Foo").Then(a => 1).Else(a => 2).Error((a, e) => 3);
            //Assert.IsTrue(doesContainIEnumThen.HasResults == true);
            //Assert.IsTrue(doesContainIEnumThen.Results == 2);
            //Assert.IsTrue(doesContainIEnumThen.HasError == false);
            //Assert.IsTrue(doesContainIEnumThen.Exception == null);

            //var doesContainIEnumElse = If.Value(stringArray).Does.Contain("fo").Then(a => 1).Else(a => 2).Error((a, e) => 3);
            //Assert.IsTrue(doesContainIEnumElse.HasResults == true);
            //Assert.IsTrue(doesContainIEnumElse.Results == 2);
            //Assert.IsTrue(doesContainIEnumElse.HasError == false);
            //Assert.IsTrue(doesContainIEnumElse.Exception == null);



            // TODO: transformresults


            // 
            // Throws
            // 
            try
            {
                If.Value<string, int>("asdf").Is.Not.Null().Throw(new NullReferenceException());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            try
            {
                If.Value<string, int>("asdf").Is.Not.Null().Throw<NullReferenceException>();
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
