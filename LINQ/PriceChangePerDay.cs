using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

    //For the year 2017, calculate the price change per day(in percentage), using the opening and closing price.

namespace LINQ
{
    public class PriceChangePerDay
    {
        public GetData GetData { get; set; } = new GetData();
        public Converter Converter { get; set; } = new Converter();
        public ConsoleLogger ConsoleLogger { get; set; } = new ConsoleLogger();
        readonly List<string> _unformattedData = new List<string>();

        public void ChangePerDay()
        {
            var values = GetEnumerable();
            CalculateChangePerDay(values);

            Console.ReadKey();
        }

        public IEnumerable<string> GetEnumerable()
        {
            var fileLocation = GetData.GetCsvData();
            var reader = new StreamReader(File.OpenRead(fileLocation));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                _unformattedData.Add(line);
            }

            var values = _unformattedData.Skip(1);
            return values;
        }

        public void CalculateChangePerDay(IEnumerable<string>values)
        {
            var query = from v in values
                let x = v.Split(';')
                where v != null
                select new
                {
                    DateTime = Converter.ConvertToDateTime(x[1]),
                    Close = Converter.ConvertToDecimal(x[4]),
                    Open = Converter.ConvertToDecimal(x[5]),
                    Difference = Converter.ConvertDifference(x[5], x[4])
                };

            foreach (var value in query)
            {
                ConsoleLogger.LogObject(value);
            }
        }
    }
}
