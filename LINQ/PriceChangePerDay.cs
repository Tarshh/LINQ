using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LINQ
{
    public class PriceChangePerDay
    {
        public GetData GetData { get; set; } = new GetData();

        public void ChangePerDay()
        {
            List<string> UnformattedData = new List<string>();

            var fileLocation = GetData.GetCsvData();
            var reader = new StreamReader(File.OpenRead(fileLocation));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                UnformattedData.Add(line);

            }

            UnformattedData.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
