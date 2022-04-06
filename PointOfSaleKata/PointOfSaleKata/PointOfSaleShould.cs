using System;
using Xunit;

namespace PointOfSaleKata
{
    public class PointOfSaleShould
    {
        [Fact]
        public void Barcode_12345_should_display_price_of_7_coma_25_euros_()
        {
            string barcode = "12345";
            double expectedPrice = 7.25;

            double result= PointOfSale.GetPriceForBarcode(barcode);

            Assert.Equal(expectedPrice, result);
        }
    }

    public class PointOfSale
    {
        public static double GetPriceForBarcode(string barcode)
        {
            throw new NotImplementedException();
        }
    }
}