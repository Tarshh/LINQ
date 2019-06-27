using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    interface IConvertable
    {
        DateTime ConvertToDateTime(string date);
        Decimal ConvertToDecimal(string number);
        string ConvertDifference(string number, string secondNumber);
    }
}
