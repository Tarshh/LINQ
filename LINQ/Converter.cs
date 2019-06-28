using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Converter : IConvertable
    {
        public DateTime ConvertToDateTime(string date)
        {
            return DateTime.Parse(date);
        }

        public Decimal ConvertToDecimal(string number)
        {
            return Convert.ToDecimal(number);
        }

        public string ConvertDifference(string open, string close)
        {
            var openPrice = ConvertToDecimal(open);
            var closePrice = ConvertToDecimal(close);
            var difference = closePrice - openPrice  ;
            var differencePercentage =  Math.Round(difference / openPrice * 100, 2);
            return $"{differencePercentage} %";

        }
    }
}
