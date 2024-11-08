﻿using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        const string data_url = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/refs/heads/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";


        private static async Task<Stream> GetDataStream()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(data_url, HttpCompletionOption.ResponseHeadersRead);
            return await response.Content.ReadAsStreamAsync();
        }

        private static IEnumerable<string> GetDataLines()
        {
            using var data_stream= GetDataStream().Result;
            using var data_reader= new StreamReader(data_stream);

            while (!data_reader.EndOfStream)
            {
                var line = data_reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;
                //                line.Replace("""")
                //              yield return line.Replace("Korea,", "Korea -");
                yield return line;
            }
        }

        private static DateTime[] GetDates() => GetDataLines()
            .First()
            .Split(',')
            .Skip(4)
            .Select(s=>DateTime.Parse(s,CultureInfo.InvariantCulture))
            .ToArray();

        private static IEnumerable<(string Country, string Province, int[] Counts)> GetData()
        {
            var lines = GetDataLines()
                .Skip(1)
                .Select(line => line.Split(','));

            foreach(var row in lines)
            {
                var province = row[0].Trim();
                var country_name = row[1].Trim(' ', '"');
                var counts = row.Skip(4).Select(int.Parse) .ToArray();

                yield return (country_name, province, counts);  
            }
        }
        static void Main(string[] args)
        {
            char ch= 'A';
            Char.IsDigit(ch);
            string st=new string('A',6);
//            st=ch.ToString();
  //          st=Char.Parse(st);  
            //var client = new HttpClient();
            //var csv_str=client.GetAsync(data_url).Result;
            //Console.WriteLine(csv_str);

            //var dates = GetDates();
            //Console.WriteLine(string.Join("\r\n", dates));

            var russia_data = GetData()
                .First(v=>v.Country.Equals("Russia", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(string.Join("\r\n", GetDates().Zip(russia_data.Counts, (date, count) => $"{date:dd:MM} - {count}")));
        }
    }
}
