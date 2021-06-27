
using System.Globalization;

namespace Heranca_Polimorfismo02.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string nameProduct, double price, double customsFee)
            : base(nameProduct, price)
        {
            CustomsFee = customsFee;
        }

        public override string PricTag()
        {
            return NameProduct + " $ " +
                TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " " +  $"(Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})" ;

        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
