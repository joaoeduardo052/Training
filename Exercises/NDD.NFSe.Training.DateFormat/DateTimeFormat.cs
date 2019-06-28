using System;

namespace NDD.NFSe.Training.DateFormat
{
    public class DateTimeFormat
    {
        //Esse método recebe uma string com um datetime e deve retornar essa mesma data no padrão ISO 8601 (AAAA-MM-DDTHH:mm:ss)
        public string FormatIso8601(string dateTime)
        {
            return null;
        }

        //Esse método recebe uma string com um datetime e deve retornar essa mesma data no padrão pt-BR (DD/MM/AAAA HH:mm:ss )
        public string FormatPtBr(string dateTime)
        {
            return null;
        }

        //Esse método recebe uma data no formato americano (MM/dd/yyyy HH:mm:ss) e deve retornar um DateTime
        public DateTime LoadFromEnglishFormat(string dateTime)
        {
            return DateTime.MinValue;
        }
    }
}