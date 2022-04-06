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

        [Fact]
        public void Barcode_23456_should_display_price_of_12_coma_50_euros_()
        {
            string barcode = "23456";
            double expectedPrice = 12.50;

            double result = PointOfSale.GetPriceForBarcode(barcode);

            Assert.Equal(expectedPrice, result);
        }

        [Fact]
        public void Barcode_99999_should_display_Error()
        {
            string barcode = "99999";
        
            var exception = Assert.Throws<Exception> (()=> PointOfSale.GetPriceForBarcode(barcode));
            Assert.Equal("Error: barcode not found",exception.Message);
            }
    }

    public class PointOfSale
    {
        public static double GetPriceForBarcode(string barcode)
        {
            if (barcode == "99999")
                throw new Exception("Error: barcode not found");
            if (barcode == "23456")
                return 12.50;
            return 7.25;
        }
    }
}