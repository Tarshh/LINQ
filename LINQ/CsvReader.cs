using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LINQ
{
    class CsvReader
    {
        public StreamReader Reader { get; set; }

        public CsvReader(StreamReader _reader)
        {
            _reader = Reader;
        }

        public string GetFileLocation()
        {
            return @"C:\Users\User\Downloads\StockMarket.csv";
        }
    }
}
