using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NDD.NFSe.Training.Tests.DateFormat
{
    [TestClass]
    public class TestDateFormat
    {
        [TestMethod]
        public void TestIso8601WithPtBtCultureShouldConvert()
        {
            new Iso8601WithPtBtCultureShouldConvert().ExecuteTest();
        }

        [TestMethod]
        public void TestIso8601WithEnUsCultureShouldConvert()
        {
            new Iso8601WithEnUsCultureShouldConvert().ExecuteTest();
        }
    }
}