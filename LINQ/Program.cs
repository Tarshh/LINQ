using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceChangePerDay priceChangePerDay = new PriceChangePerDay();
            priceChangePerDay.ChangePerDay();

         

        }
    }
}
