using System;
using System.Globalization;

namespace Product_Test
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantidade)
        {
            Quantity += quantidade;
        }
        public void RemoveProducts(int quantidade)
        {
            Quantity -= quantidade;
        }

        public override string ToString()
        {
            return Name + ", $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " Unidades , " + "Total: $ " + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
