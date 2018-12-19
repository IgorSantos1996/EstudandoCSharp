using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ExercicioPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct(string name, double price, double customsfree) : base(name, price)
        {
            CustomsFree = customsfree;
        }
        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $ " +
                CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
        public double totalPrice()
        {
            return Price + CustomsFree;
        }

    }
}
