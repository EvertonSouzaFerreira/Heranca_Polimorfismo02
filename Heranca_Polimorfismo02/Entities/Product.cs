
using System.Globalization;

namespace Heranca_Polimorfismo02.Entities
{
    class Product
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price;
        }

        public virtual string PricTag()
        {
            return NameProduct + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
