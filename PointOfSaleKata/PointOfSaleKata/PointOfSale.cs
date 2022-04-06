using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSaleKata;

public class PointOfSale
{
    private static Dictionary<string,double> prices = new Dictionary<string, double>() { { "23456", 12.50 }, { "12345", 7.25 } };


    public static double GetPriceForBarcode(string barcode)
    { 
        double barcodeprice;

        if (string.IsNullOrEmpty(barcode) ) throw new Exception("Error: empty barcode");
        if (barcode == "Total") return prices.Sum(p => p.Value);
        if (!prices.TryGetValue(barcode, out barcodeprice))
            throw new Exception("Error: barcode not found");
        return barcodeprice;
    }
}