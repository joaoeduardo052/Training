using NDD.NFSe.Training.DateFormat;

namespace NDD.NFSe.Training.Tests.DateFormat
{
    public abstract class DateFormatBase : TestBase
    {
        protected DateTimeFormat DateTimeFormat;

        protected override void Initialize()
        {
            DateTimeFormat = new DateTimeFormat();
        }

        protected override void Setup() { }
    }
}