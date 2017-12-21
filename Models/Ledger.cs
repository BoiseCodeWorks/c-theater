using System.Collections.Generic;
using theater.Interfaces;

namespace theater.Models
{

    public class Ledger
    {
        List<IPurchasable> Sales { get; set; }

        double CalculateSales()
        {
            double total = 0;
            foreach (var sale in Sales)
            {
                total += sale.Price;
            }
            return total;
        }


    }

}