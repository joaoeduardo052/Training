using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NDD.NFSe.Training.Tests.DateFormat
{
    [TestClass]
    public class TestDateFormat
    {
        [TestMethod]
        public void Test_01_Iso8601WithPtBtCulture_ShouldConvert()
        {
            new Iso8601WithPtBtCultureShouldConvert().ExecuteTest();
        }

        [TestMethod]
        public void Test_02_Iso8601WithEnUsCulture_ShouldConvert()
        {
            new Iso8601WithEnUsCultureShouldConvert().ExecuteTest();
        }

        [TestMethod]
        public void Test_03_FormatPtBrWithPtBrCulture_ShouldConvert()
        {
            new FormatPtBrWithPtBrCultureShouldConvert().ExecuteTest();
        }

        [TestMethod]
        public void Test_04_FormatPtBrWithEnUsCulture_ShouldConvert()
        {
            new FormatPtBrWithEnUsCultureShouldConvert().ExecuteTest();
        }

        [TestMethod]
        public void Test_05_LoadFromEnglishFormatWithPtBrCulture_ShouldConvert()
        {
            new LoadFromEnglishFormatWithPtBrCultureShouldConvert().ExecuteTest();
        }

        [TestMethod]
        public void Test_06_LoadFromEnglishFormatWithEnUsCulture_ShouldConvert()
        {
            new LoadFromEnglishFormatWithEnUsCultureShouldConvert().ExecuteTest();
        }
    }
}