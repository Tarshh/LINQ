using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<StockPrice> data = new List<StockPrice>();
            List<string>UnformattedData = new List<string>();
            var fileLocation = @"C:\Users\User\Downloads\StockMarket.csv";
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
