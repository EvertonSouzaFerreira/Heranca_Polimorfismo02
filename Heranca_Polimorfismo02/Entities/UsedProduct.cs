using System;
using System.Globalization;

namespace Heranca_Polimorfismo02.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string nameProduct, double price, DateTime manufactureDate)
            : base(nameProduct, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PricTag()
        {
            return NameProduct + " (used) $" + Price.ToString("F2",CultureInfo.InvariantCulture)
                + "(Manufacture date: "
                + ManufactureDate.ToString("dd/mm/yyyy")+ ")";
        }
    }
}
