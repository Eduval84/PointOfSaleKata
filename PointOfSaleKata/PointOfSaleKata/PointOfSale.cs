using System;
using System.Collections;
using System.Collections.Generic;

namespace PointOfSaleKata;

public class PointOfSale
{
    private static Dictionary<string,double> prices = new Dictionary<string, double>() { { "23456", 12.50 }, { "12345", 7.25 } };


    public static double GetPriceForBarcode(string barcode)
    { 
        double barcodeprice;

        if (!prices.TryGetValue(barcode, out barcodeprice))
            throw new Exception("Error: barcode not found");
        return barcodeprice;
    }
}