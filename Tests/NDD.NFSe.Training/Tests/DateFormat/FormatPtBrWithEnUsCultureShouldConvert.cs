using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;

namespace NDD.NFSe.Training.Tests.DateFormat
{
    public class FormatPtBrWithEnUsCultureShouldConvert : DateFormatBase
    {
        private string InputValue1;
        private string ResultValue1;

        private string InputValue2;
        private string ResultValue2;

        private string InputValue3;
        private string ResultValue3;

        private string InputValue4;
        private string ResultValue4;

        protected override void Initialize()
        {
            base.Initialize();

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            InputValue1 = "2019-09-26";
            InputValue2 = "2019-7-4 13:01:18";
            InputValue3 = "5-8-2017";
            InputValue4 = "27-3-2015 6:18:3";
        }

        protected override void When()
        {
            ResultValue1 = DateTimeFormat.FormatPtBr(InputValue1);
            ResultValue2 = DateTimeFormat.FormatPtBr(InputValue2);
            ResultValue3 = DateTimeFormat.FormatPtBr(InputValue3);
            ResultValue4 = DateTimeFormat.FormatPtBr(InputValue4);
        }

        protected override void Then(Exception triggeredException = null)
        {
            triggeredException.Should().BeNull(triggeredException?.ToString());

            ResultValue1.Should().Be("26/09/2019 00:00:00");
            ResultValue2.Should().Be("04/07/2019 13:01:18");
            ResultValue3.Should().Be("05/08/2017 00:00:00");
            ResultValue4.Should().Be("27/03/2015 06:18:03");
        }
    }
}