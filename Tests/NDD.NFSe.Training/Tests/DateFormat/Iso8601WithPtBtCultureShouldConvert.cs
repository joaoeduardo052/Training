using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;

namespace NDD.NFSe.Training.Tests.DateFormat
{
    public class Iso8601WithPtBtCultureShouldConvert : DateFormatBase
    {
        private string ValueInput1;
        private string ValueResult1;

        private string ValueInput2;
        private string ValueResult2;

        private string ValueInput3;
        private string ValueResult3;

        private string ValueInput4;
        private string ValueResult4;

        protected override void Initialize()
        {
            base.Initialize();

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

            ValueInput1 = "15/04/2019 16:37:15";
            ValueInput2 = "06-08-2019 10:21:01";
            ValueInput3 = "2018-03-16";
            ValueInput4 = "2018-06-02";
        }

        protected override void When()
        {
            ValueResult1 = DateTimeFormat.FormatIso8601(ValueInput1);
            ValueResult2 = DateTimeFormat.FormatIso8601(ValueInput2);
            ValueResult3 = DateTimeFormat.FormatIso8601(ValueInput3);
            ValueResult4 = DateTimeFormat.FormatIso8601(ValueInput4);
        }

        protected override void Then(Exception triggeredException = null)
        {
            triggeredException.Should().BeNull(triggeredException?.ToString());

            ValueResult1.Should().Be("2019-04-15T16:37:15");
            ValueResult2.Should().Be("2019-08-06T10:21:01");
            ValueResult3.Should().Be("2018-03-16T00:00:00");
            ValueResult3.Should().Be("2018-06-02T00:00:00");
        }
    }
}