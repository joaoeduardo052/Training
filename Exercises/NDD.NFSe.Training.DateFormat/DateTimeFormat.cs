using System;
using System.Globalization;

namespace NDD.NFSe.Training.DateFormat
{
    public class DateTimeFormat
    {
        //Esse método recebe uma string com um datetime e deve retornar essa mesma data no padrão ISO 8601 (AAAA-MM-DDTHH:mm:ss)
        public string FormatIso8601(string dateTime)
        {
            CultureInfo Cultura = new CultureInfo("pt-BR");
            var data = DateTime.Parse(dateTime, Cultura).ToString("yyyy-MM-ddTHH:mm:ss");

            return data;
        }

        //Esse método recebe uma string com um datetime e deve retornar essa mesma data no padrão pt-BR (DD/MM/AAAA HH:mm:ss)
        public string FormatPtBr(string dateTime)
        {
            CultureInfo Cultura = new CultureInfo("pt-BR");
            var data = DateTime.Parse(dateTime, Cultura).ToString("dd/MM/yyyy HH:mm:ss");

            return data;
        }

        //Esse método recebe uma data no formato americano (MM/DD/AAAA HH:mm:ss) e deve retornar um DateTime
        public DateTime LoadFromEnglishFormat(string dateTime)
        {
            CultureInfo Cultura = new CultureInfo("en-US");
            var data = DateTime.Parse(dateTime, Cultura);

            return data;
        }
    }
}