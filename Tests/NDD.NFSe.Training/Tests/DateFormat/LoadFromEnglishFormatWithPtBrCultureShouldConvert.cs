using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;

namespace NDD.NFSe.Training.Tests.DateFormat
{
    public class LoadFromEnglishFormatWithPtBrCultureShouldConvert : DateFormatBase
    {
        private string InputValue1;
        private DateTime ResultValue1;

        private string InputValue2;
        private DateTime ResultValue2;

        private string InputValue3;
        private DateTime ResultValue3;

        private string InputValue4;
        private DateTime ResultValue4;

        private string InputValue5;
        private DateTime ResultValue5;

        protected override void Initialize()
        {
            base.Initialize();

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

            InputValue1 = "4/9/2019"; //2019-04-09
            InputValue2 = "11/27/2019"; //2019-11-27
            InputValue3 = "7/3/2019 8:21:00"; //2019-07-03 08:21:00
            InputValue4 = "2018-06-09 01:51:03"; //2018-06-09 01:51:03
            InputValue5 = "2018-06-21 07:13:33"; //2018-06-21 07:13:33
        }

        protected override void When()
        {
            ResultValue1 = DateTimeFormat.LoadFromEnglishFormat(InputValue1);
            ResultValue2 = DateTimeFormat.LoadFromEnglishFormat(InputValue2);
            ResultValue3 = DateTimeFormat.LoadFromEnglishFormat(InputValue3);
            ResultValue4 = DateTimeFormat.LoadFromEnglishFormat(InputValue4);
            ResultValue5 = DateTimeFormat.LoadFromEnglishFormat(InputValue5);
        }

        protected override void Then(Exception triggeredException = null)
        {
            triggeredException.Should().BeNull(triggeredException?.ToString());

            ResultValue1.Should().Be(Convert.ToDateTime("2019-04-09"));
            ResultValue2.Should().Be(Convert.ToDateTime("2019-11-27"));
            ResultValue3.Should().Be(Convert.ToDateTime("2019-07-03 08:21:00"));
            ResultValue4.Should().Be(Convert.ToDateTime("2018-06-09 01:51:03"));
            ResultValue5.Should().Be(Convert.ToDateTime("2018-06-21 07:13:33"));
        }
    }
}