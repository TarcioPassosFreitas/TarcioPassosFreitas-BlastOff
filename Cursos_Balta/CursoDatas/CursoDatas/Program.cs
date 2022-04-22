using System;
using System.Globalization;

namespace CursoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //var data = new DateTime(); é um struct. Desse jeito que foi instanciado, acaba trazendo uma data pré deficinida
            //Não inicializa a data com valor nulo
            // var data = DateTime.Now; //data de hoje
            //var data = new DateTime(2020, 10, 12, 8, 23, 14); //AA/mm/dd HH:mm:ss
            // var data = new DateTime(2020, 10, 12, 13, 23, 14); //13 horas, já converte para 1 pm

            // System.Console.WriteLine(data);
            // System.Console.WriteLine(data.Year);
            // System.Console.WriteLine(data.Month);
            // System.Console.WriteLine(data.Day);
            // System.Console.WriteLine(data.Hour);
            // System.Console.WriteLine(data.Minute);
            // System.Console.WriteLine(data.Second);

            // System.Console.WriteLine(data.DayOfWeek);
            // System.Console.WriteLine((int)data.DayOfWeek);
            // System.Console.WriteLine(data.DayOfYear);

            var data = DateTime.Now;
            // Y -> simboliza ano
            // M -> simboliza mês
            // d -> simboliza o dia
            // h -> simboliza a hora
            // m -> simboliza o minuto
            // s -> simboliza o segundo
            // f -> fração de segundos
            // z -> time zone, onde essa hora ta sendo baseada
            //var formatada = string.Format("{0:yyyy}", data); //:formato do jeito que quer, no caso no formato ano.
            // 4 vezes o y é o ano cheio, no caso 2022
            // 3 ou 2 vezes o y, o ano, no caso 22
            // 1 vez o y, aparece o mês e o ano, no caso may 2022
            //var formatada = string.Format("{0:mm}", data);
            var formatada = string.Format("{0:yyyy-MM-dd}", data);
            //no lugar de - , pode colocar qualquer coisa
            //var formatada = string.Format("{0:yyyy * MM * dd}", data);
            // var formatada = string.Format("{0:yyyy/MM/dd}", data);
            //Em português
            //var formatada = string.Format("{0:dd/MM/yyyy}", data);
            //var formatada = string.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            //var formatada = string.Format("{0:dd/MM/yyyy hh:mm:ss ff}", data);
            //var formatada = string.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
            //Nesse caso o z vai ser -3, pois estamos no Brasil. GMT

            // var formatada = string.Format("{0:t}", data); short
            // var formatada = string.Format("{0:T}", data);
            // var formatada = string.Format("{0:d}", data);
            // var formatada = string.Format("{0:D}", data);
            // var formatada = string.Format("{0:g}", data); //combina data e hora só que no short
            // var formatada = string.Format("{0:r}", data); //Deixa no padrão que muitos usam (RC123)
            // var formatada = string.Format("{0:R}", data);
            // var formatada = string.Format("{0:s}", data);//nos padrõs JSON
            // var formatada = string.Format("{0:u}", data); // Padrão universal

            //Evitar cenário
            //var dia = data.Day + 1 -> evitar usar dessa forma
            //Sempre que possível, reaproveitar os métodos.
            //No caso de ano bissexto ou algo parecido

            System.Console.WriteLine(data);

            data.AddDays(12);
            //data.AddDays(-12); subtraindo 
            System.Console.WriteLine(data);

            data.AddMonths(1);
            System.Console.WriteLine(data);

            data.AddYears(1);
            System.Console.WriteLine(data);

            data.AddHours(1);
            System.Console.WriteLine(data);

            data.AddMinutes(1);
            System.Console.WriteLine(data);

            data.AddSeconds(1);
            System.Console.WriteLine(data);

            //Comparação de datas

            //DateTime? data = null; //data que pode ser nula
            if (data == DateTime.Now)
            { //Não vai aparecer é igual. Diferença de frações de segundo
                System.Console.WriteLine("É igual");
            }

            if (data >= DateTime.Now)
            {
                System.Console.WriteLine("É igual");
            }

            if (data.Date == DateTime.Now.Date)
            { //Vai aparcer é igual, pois está comparando só o date.
                System.Console.WriteLine("É igual");
            }


            //Localização e Globalização

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var enk = new CultureInfo("en-UK");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture; //cultura do pc

            System.Console.WriteLine(DateTime.Now.ToString("D", pt));
            System.Console.WriteLine(DateTime.Now.ToString("D", de));

            //Time zone
            //Caso trabalhe com apps, sites, que seja de outros lugares fora do Brasil, aconselha-se usar o
            var utcDate = DateTime.UtcNow; //data no formato puro
            System.Console.WriteLine(utcDate);

            System.Console.WriteLine(utcDate.ToLocalTime());

            //verifica o timezone da australia
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Australiand");
            System.Console.WriteLine(timezoneAustralia);
            //A hora com o timezone da região aplicado
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            System.Console.WriteLine(horaAustralia);
            //passar a data para utc
            //var horaAustralia = TimeZoneInfo.ConvertTimeToUtc(utcDate, timezoneAustralia);
            var timezones = TimeZoneInfo.GetSystemTimeZones(); //listar todos os timezones disponíveis
            foreach (var timezone in timezones)
            {
                System.Console.WriteLine(timezone.Id);
                System.Console.WriteLine(timezone);
                System.Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                System.Console.WriteLine("----------");
            }

            //timespan

            var timespan = new TimeSpan(); //inicializa zerado
            System.Console.WriteLine(timespan);

            var timespanNanoSegundos = new TimeSpan(1); //inicializa com o nanosegundo
            System.Console.WriteLine(timespanNanoSegundos);

            var timespanHoraMinutoSegundo = new TimeSpan(5, 12, 8); //3 dados, hora, minuto e segundo
            System.Console.WriteLine(timespanHoraMinutoSegundo);

            var timespanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10); //4 dados, dia, hora, minuto e segundo
            System.Console.WriteLine(timespanDiaHoraMinutoSegundo);

            var timespanDiahoraMinutosSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100); //5 dados, dia hora, minuto, segundo e milissegundo
            System.Console.WriteLine(timespanDiahoraMinutosSegundoMilissegundo);

            System.Console.WriteLine(timespanHoraMinutoSegundo - timespanDiaHoraMinutoSegundo);
            System.Console.WriteLine(timespanDiaHoraMinutoSegundo.Days);
            System.Console.WriteLine(timespanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            //dias do mês, dado um ano e um mês
            System.Console.WriteLine(DateTime.DaysInMonth(2022, 4)); //lembrando que mês começa do 1

            //é final de semana ou não
            //tem função pra isso
            System.Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            //saber se é horário de versão
            //retorna um booleano
            System.Console.WriteLine(DateTime.Now.IsDaylightSavingTime());








            System.Console.WriteLine(formatada);
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}
